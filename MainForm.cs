using System;
using System.Windows.Forms;
using Logic;
using Facade;
using System.Threading;
using System.Collections.Generic;

namespace Design
{
    public delegate void dataBindingUpdateDelegate();
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabPageCliques);
            tabControl.TabPages.Remove(tabPageExport);
            r_FacadeHomePage = new FacadeHomePage();
            r_FacadeCliqueAnalysis = new FacadeCliqueAnalysis();
            r_FacadeExportResults = new FacadeExportResults();
        }

        private readonly FacadeHomePage r_FacadeHomePage;
        private readonly FacadeCliqueAnalysis r_FacadeCliqueAnalysis;
        private readonly FacadeExportResults r_FacadeExportResults;
        private bool m_AllAnalyzed = false;
        private bool m_IsloggedIn = false;

        private void loginWithCredentials()
        {
            try
            {
                if (m_IsloggedIn == false)
                {
                    r_FacadeHomePage.LoginWithCredentials();
                    m_IsloggedIn = true;
                }
            }
            catch (Facebook.FacebookOAuthException fbau)
            {
                throw fbau;
            }

        }

        private void loadLoggedInUserInfo()
        {
            if (m_IsloggedIn == true)
            {
                new Thread(fetchUserProfilePicture).Start();
                labelUserName.Text = string.Format("Welcome back {0}", r_FacadeHomePage.GetUserName());
                tabControl.TabPages.Add(tabPageCliques);
            }
            else
            {
                MessageBox.Show("Log in first");
            }
        }

        private void fillUserPosts()
        {
            if (r_FacadeHomePage.GetUserPosts().Count > 0)
            {
                foreach (var postString in r_FacadeHomePage.GetUserPosts())
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(postString)));
                }
            }
            else
            {
                MessageBox.Show("Nothing to show");
            }
        }

        private void fetchUserProfilePicture()
        {
            pictureBoxProfilePicture.LoadAsync(r_FacadeHomePage.GetProfilePictureUrl());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_IsloggedIn == false)
            {
                if (checkBoxLogin.Checked == true || checkBoxLoginToken.Checked == true)
                {
                    try
                    {
                        if (checkBoxLogin.Checked == true)
                        {
                            loginWithCredentials();
                        }
                        else if (checkBoxLoginToken.Checked == true)
                        {
                            loginWithToken();
                        }

                        loadLoggedInUserInfo();
                        hideLoginComponents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Must check login option");
                }
            }
        }

        private void hideLoginComponents()
        {
            buttonLogin.Visible = false;
            checkBoxLogin.Visible = false;
            checkBoxLoginToken.Visible = false;
            textBoxToken.Visible = false;
        }

        private void loginWithToken()
        {
            try
            {
                if (m_IsloggedIn == false)
                {
                    r_FacadeHomePage.LoginWithToken(textBoxToken.Text);
                    m_IsloggedIn = true;
                }
            }
            catch (Facebook.FacebookOAuthException fbau)
            {
                throw fbau;
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            if (m_IsloggedIn == true)
            {
                new Thread(fetchFriends).Start();
            }
            else
            {
                MessageBox.Show("Log in first");
            }
        }

        private void fetchFriends()
        {
            List<string> userFriends = new List<string>();
            userFriends = r_FacadeHomePage.GetUserFriends();
            if (userFriends.Count > 0)
            {
                foreach (var item in userFriends)
                {
                    treeViewFriends.Invoke(new Action(() => treeViewFriends.Nodes.Add(item)));
                }

                treeViewFriends.Invoke(new Action(() => treeViewFriends.Refresh()));
            }
            else
            {
                MessageBox.Show("Nothing to show");
            }
        }

        private void treeViewFriends_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                if (e.Node.Text != r_FacadeHomePage.GetUserName())
                {
                    try
                    {
                        foreach (string friendName in r_FacadeHomePage.GetFriendFriendListByGivingHisName(e.Node.Text))
                        {
                            e.Node.Nodes.Add(friendName);
                        }
                        e.Node.ExpandAll();
                        pictureBoxFriendImage.LoadAsync(r_FacadeHomePage.GetFriendImageUrlByGivingHisName(e.Node.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    pictureBoxFriendImage.LoadAsync(r_FacadeHomePage.GetProfilePictureUrl());
                }
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            if (m_IsloggedIn == true)
            {
                new Thread(fillUserPosts).Start();
                //fillUserPosts();
            }
            else
            {
                MessageBox.Show("Log in first");
            }
        }

        private void buttonMakeCliques_Click(object sender, EventArgs e)
        {
            new Thread(buildCliquesTree).Start();
        }

        private void eraseMemberDetails()
        {
            isAnalyzedLabel2.Text = "";
            mostInterestLabel2.Text = "";
            imageNormalPictureBox.Image = null;
        }

        private void buildCliquesTree()
        {
            treeViewCliques.Nodes.Clear();
            if(m_AllAnalyzed == false)
            {
                r_FacadeCliqueAnalysis.Construct(r_FacadeHomePage.LoggedInUser);

            }

            if (r_FacadeCliqueAnalysis.Cliques != null)
            {
                foreach (var clique in r_FacadeCliqueAnalysis.Cliques)
                {
                    TreeNode currentCliqueNode = new TreeNode();
                    currentCliqueNode.Text = string.Format("Clique - {0}", clique.Value.ID);
                    currentCliqueNode.Tag = clique.Value.ID;
                    foreach (Member member in clique.Value.CliqueMembers.Values)
                    {
                        currentCliqueNode.Nodes.Add(member.Name);
                    }

                    treeViewCliques.Invoke(new Action(() => treeViewCliques.Nodes.Add(currentCliqueNode)));
                }
                MessageBox.Show("Operation ended successfully");
            }
            else
            {
                MessageBox.Show("Nothing to show");
            }
        }

        private void buildCliquesTree(Dictionary<int, Clique> i_CliquesToShow)
        {
            treeViewCliques.Nodes.Clear();

            if (i_CliquesToShow != null)
            {
                foreach (var clique in i_CliquesToShow)
                {
                    TreeNode currentCliqueNode = new TreeNode();
                    currentCliqueNode.Text = string.Format("Clique - {0}", clique.Value.ID);
                    currentCliqueNode.Tag = clique.Value.ID;
                    foreach (Member member in clique.Value.CliqueMembers.Values)
                    {
                        currentCliqueNode.Nodes.Add(member.Name);
                    }

                    treeViewCliques.Invoke(new Action(() => treeViewCliques.Nodes.Add(currentCliqueNode)));
                }
                MessageBox.Show("Operation ended successfully");
            }
            else
            {
                MessageBox.Show("Nothing to show");
            }
        }

        private void buttonAnalyzeClique_Click(object sender, EventArgs e)
        {
            if (treeViewCliques.SelectedNode != null)
            {
                TreeNode SelectedClique = determineCliqueByGivenNode();
                if (treeViewCliques.Nodes.Count > 0)
                {
                    if (SelectedClique != null)
                    {
                        analyzeSpecificClique(SelectedClique);
                    }
                    else
                    {
                        MessageBox.Show("Please select a clique first");
                    }
                }
                else
                {
                    MessageBox.Show("You must make cliques before analyzing");
                }
            }
            else
            {
                MessageBox.Show("You must pick a clique");
            }

        }

        private void checkIfAllCliquesAreAnalyzed()
        {
            foreach (var item in treeViewCliques.Nodes)
            {
                int currentIndex = (item as TreeNode).Index;
                if (r_FacadeCliqueAnalysis.Cliques[currentIndex].isAnalyzed == false)
                {
                    break;
                }

                m_AllAnalyzed = true;
            }
        }

        private void analyzeSpecificClique(TreeNode i_GivenClique)
        {
            try
            {
                Clique currentClique = r_FacadeCliqueAnalysis.Cliques[i_GivenClique.Index];
                if (currentClique.isAnalyzed == false)
                {
                    new Thread(() =>
                       {
                           r_FacadeCliqueAnalysis.DetermineCliqueMainInterest(currentClique);
                           checkIfAllCliquesAreAnalyzed();
                           MessageBox.Show("Clique analyzed");
                           checkIfExportTabNeedsToBeAdded();
                           changeDataSourceData();
                       }).Start();
                }
                else
                {
                    MessageBox.Show(string.Format("Clique - {0} is Already analyzed", currentClique.ID.ToString()));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeDataSourceData()
        {
            dataBindingUpdateDelegate currentUpdate = new dataBindingUpdateDelegate(updatesAnalyzeGroupBox);
            foreach (Control control in groupBoxAnalayze.Controls)
            {
                control.Invoke(currentUpdate);
            }
        }

        private void updatesAnalyzeGroupBox()
        {
            cliquesBindingSource.ResetBindings(false);
        }

        private TreeNode determineCliqueByGivenNode()
        {
            TreeNode selectedNode = treeViewCliques.SelectedNode;
            TreeNode returned = new TreeNode();

            if (selectedNode.Parent != null)
            {
                returned = selectedNode.Parent;
            }
            else if (selectedNode.Parent == null)
            {
                returned = selectedNode;
            }

            return returned;
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            if (m_IsloggedIn == true)
            {
                new Thread(fetchGroups).Start();
            }
            else
            {
                MessageBox.Show("Login first");
            }
        }

        private void fetchGroups()
        {
            if (r_FacadeHomePage.GetUserGroups().Count > 0)
            {
                foreach (string groupString in r_FacadeHomePage.GetUserGroups())
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(groupString)));
                }
            }

            else
            {
                MessageBox.Show("Nothing to show");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                pictureBoxGroup.LoadAsync(r_FacadeHomePage.GetGroupPictureUrl(listBoxGroups.SelectedItem.ToString()));
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                pictureBoxPage.LoadAsync(r_FacadeHomePage.GetPagePictureUrl(listBoxPages.SelectedItem.ToString()));
            }
        }

        private void buttonPages_Click(object sender, EventArgs e)
        {
            if (m_IsloggedIn == true)
            {
                fetchPages();
            }
            else
            {
                MessageBox.Show("Please login first");
            }

        }

        private void fetchPages()
        {
            if (r_FacadeHomePage.GetUserPages().Count > 0)
            {
                foreach (var page in r_FacadeHomePage.GetUserPages())
                {
                    listBoxPages.Invoke(new Action(() => listBoxPages.Items.Add(page)));
                }
            }
            else
            {
                MessageBox.Show("Nothing to show");
            }
        }

        private void checkBoxExportEverything_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExportEverything.Checked == true)
            {
                if (m_AllAnalyzed == true)
                {
                    checkBoxExportSpecificClique.Visible = false;
                    listBoxExportSpecificClique.Visible = false;
                }
                else
                {
                    checkBoxExportEverything.Checked = false;
                }
            }
            else
            {
                checkBoxExportSpecificClique.Visible = true;
            }
        }

        private void buttonAnalyzeAllCliques_Click(object sender, EventArgs e)
        {
            if (treeViewCliques.Nodes.Count > 0)
            {
                annalyzeAllCliques();
            }
            else
            {
                MessageBox.Show("You must make cliques before analyzing");
            }
        }

        private void annalyzeAllCliques()
        {
            if (m_AllAnalyzed == false)
            {
                if (treeViewCliques.SelectedNode != null)
                {
                    TreeNode selectedClique = determineCliqueByGivenNode();
                }
                try
                {
                    new Thread(() =>
                    {
                        foreach (TreeNode treeNode in treeViewCliques.Nodes)
                        {
                            Clique currentClique = r_FacadeCliqueAnalysis.Cliques[treeNode.Index];
                            try
                            {
                                if (currentClique.isAnalyzed == false)
                                {
                                    r_FacadeCliqueAnalysis.DetermineCliqueMainInterest(currentClique);
                                    cliquesBindingSource.DataSource = r_FacadeCliqueAnalysis.Cliques[treeNode.Index];
                                }
                                else
                                {
                                    MessageBox.Show(string.Format("{0} - Already analyzed", treeNode.Text));
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(string.Format("Error analyzing clique - {0} : {1}", currentClique.ID.ToString(), ex.Message));
                            }
                        }
                        m_AllAnalyzed = true;
                        changeDataSourceData();
                        MessageBox.Show("Analyzed Successfuly");

                        checkIfExportTabNeedsToBeAdded();
                    }).Start();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error occured - " + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Everything already analyzed");
            }
        }

        private void checkIfExportTabNeedsToBeAdded()
        {
            if (tabControl.TabPages.Count == 2)
            {
                tabControl.Invoke(new Action(() => tabControl.TabPages.Add(tabPageExport)));
            }
        }

        private void checkBoxExportSpecificClique_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExportSpecificClique.Checked == true)
            {
                if (listBoxExportSpecificClique.Items.Count == 0)
                {
                    foreach (var clique in r_FacadeCliqueAnalysis.Cliques)
                    {
                        if (clique.Value.isAnalyzed)
                        {
                            listBoxExportSpecificClique.Items.Add(clique.Key);
                        }
                    }
                }
                listBoxExportSpecificClique.Visible = true;
            }
            else
            {
                listBoxExportSpecificClique.Visible = false;
                listBoxExportSpecificClique.Items.Clear();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (checkBoxExportEverything.Checked == true)
            {
                exportAll();
            }
            else
            {
                exportSpecific();
            }
        }

        private void exportSpecific()
        {
            List<eFileFormat> wantedFormats;

            if (determineDesirefFormats(out wantedFormats))
            {
                try
                {
                    int index = int.Parse(listBoxExportSpecificClique.Text);
                    new Thread(() =>
                    {
                        List<CliqueDocument> docs = r_FacadeExportResults.ConstructDocument(r_FacadeCliqueAnalysis.Cliques[index], wantedFormats, textBoxLocalDisPath.Text);
                        foreach (var doc in docs)
                        {
                            doc.Selected();
                        }
                    }).Start();
                    MessageBox.Show("Exported successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Must check format");
            }
        }

        private bool determineDesirefFormats(out List<eFileFormat> wantedFormats)
        {
            bool checkedSomething = false;
            wantedFormats = new List<eFileFormat>();

            if (checkBoxExportXml.Checked == true)
            {
                wantedFormats.Add(eFileFormat.XML);
                checkedSomething = true;
            }
            if (checkBoxExportText.Checked == true)
            {
                wantedFormats.Add(eFileFormat.TXT);
                checkedSomething = true;
            }

            return checkedSomething;
        }

        private void exportAll()
        {
            List<eFileFormat> desiredFormats;

            if (determineDesirefFormats(out desiredFormats))
            {
                try
                {
                    new Thread(() =>
                    {
                        List<CliqueDocument> docs = r_FacadeExportResults.ConstructDocument(r_FacadeCliqueAnalysis.Cliques.Values, desiredFormats, textBoxLocalDisPath.Text);
                        foreach (var doc in docs)
                        {
                            doc.Selected();
                        }
                    }).Start();
                    MessageBox.Show("Exported successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            else
            {
                MessageBox.Show("Must check format");
            }
        }

        private void checkBoxLoginToken_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoginToken.Checked == true)
            {
                checkBoxLogin.Visible = false;
            }
            else
            {
                checkBoxLogin.Visible = true;
            }
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked == true)
            {
                checkBoxLoginToken.Visible = false;
                textBoxToken.Visible = false;
            }
            else
            {
                checkBoxLoginToken.Visible = true;
                textBoxToken.Visible = true;

            }
        }

        private void treeViewCliques_AfterSelect(object sender, TreeViewEventArgs e)
        {
            eraseMemberDetails();

            if (e.Node.Parent != null)
            {
                Member current = r_FacadeCliqueAnalysis.Cliques[(int)e.Node.Parent.Tag].CliqueMembers[e.Node.Text];
                cliqueMembersBindingSource.DataSource = current;
                cliquesBindingSource.DataSource = r_FacadeCliqueAnalysis.Cliques[(int)e.Node.Parent.Tag];
            }
            else
            {
                cliquesBindingSource.DataSource = r_FacadeCliqueAnalysis.Cliques[(int)e.Node.Tag];
            }
        }

        private void checkBoxFilterByMostInterestedCount_CheckedChanged(object sender, EventArgs e)
        {
            if (m_AllAnalyzed == true)
            {
                if (checkBoxFilterByMostInterestedCount.Checked == true)
                {
                    int desiredCount;
                    if (int.TryParse(textBoxMostInterstedFilterCount.Text, out desiredCount))
                    {
                        CliquesFilter cf = new CliquesFilter(clique => clique.MostInterestMembersCount > desiredCount);
                        checkBoxFilterByHiking.Checked = false;
                        Dictionary<int, Clique> filtered = r_FacadeCliqueAnalysis.FilterCliques(cf);
                        buildCliquesTree(filtered);
                    }
                    else
                    {
                        MessageBox.Show("Must pick a positiv number only");
                    }

                }
            }
            else
            {
                MessageBox.Show("Analayze all first");
            }
        }

        private void checkBoxFilterByHiking_CheckedChanged(object sender, EventArgs e)
        {
            if (m_AllAnalyzed == true)
            {
                if (checkBoxFilterByHiking.Checked == true)
                {                   
                        CliquesFilter cf = new CliquesFilter(clique => clique.MostInterest == eMostInterest.Hiking);
                        checkBoxFilterByHiking.Checked = false;
                        Dictionary<int, Clique> filtered = r_FacadeCliqueAnalysis.FilterCliques(cf);
                        buildCliquesTree(filtered);                   
                }
            }
            else
            {
                MessageBox.Show("Analayze all first");
            }
        }

        private void buttonRestorePreviousTree_Click(object sender, EventArgs e)
        {
            checkBoxDisplayOnlyFemales.Checked = false;
            checkBoxFilterByHiking.Checked = false;
            checkBoxFilterByMostInterestedCount.Checked = false;
            treeViewCliques.Nodes.Clear();
            buildCliquesTree();
        }

        private void checkBoxDisplayOnlyFemales_CheckedChanged(object sender, EventArgs e)
        {
            if (m_AllAnalyzed == true)
            {
                Dictionary<int, Clique> femaleDict = r_FacadeCliqueAnalysis.GetFemaleCliquesOnly();
                buildCliquesTree(femaleDict);
            }
            else
            {
                MessageBox.Show("Analayze all first");
            }
        }

        
    }

}
