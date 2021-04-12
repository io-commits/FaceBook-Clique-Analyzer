using System;
using System.Windows.Forms;

namespace Design
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dominantGenderLabel;
            System.Windows.Forms.Label femaleCountLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label isAnalyzedLabel;
            System.Windows.Forms.Label malesCountLabel;
            System.Windows.Forms.Label membersCountLabel;
            System.Windows.Forms.Label mostInterestLabel;
            System.Windows.Forms.Label mostInterestMembersCountLabel;
            System.Windows.Forms.Label rankLabel;
            System.Windows.Forms.Label isAnalyzedLabel1;
            System.Windows.Forms.Label mostInterestLabel1;
            System.Windows.Forms.Label imageNormalLabel;
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.treeViewFriends = new System.Windows.Forms.TreeView();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.labelFriendImage = new System.Windows.Forms.Label();
            this.pictureBoxFriendImage = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxLoginToken = new System.Windows.Forms.CheckBox();
            this.Posts = new System.Windows.Forms.GroupBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.groupBoxPages = new System.Windows.Forms.GroupBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.buttonPages = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.groupBoxUserGroups = new System.Windows.Forms.GroupBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.labelGroups = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPageCliques = new System.Windows.Forms.TabPage();
            this.groupBoxAnalayze = new System.Windows.Forms.GroupBox();
            this.dominantGenderLabelValue = new System.Windows.Forms.Label();
            this.cliquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.femaleCountLabelValue = new System.Windows.Forms.Label();
            this.iDLabelValue = new System.Windows.Forms.Label();
            this.isAnalyzedLabelValue = new System.Windows.Forms.Label();
            this.malesCountLabelValue = new System.Windows.Forms.Label();
            this.membersCountLabelValue = new System.Windows.Forms.Label();
            this.mostInterestLabelValue = new System.Windows.Forms.Label();
            this.mostInterestMembersCountLabelValue = new System.Windows.Forms.Label();
            this.rankLabelValue = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxCliquesInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxDisplayOnlyFemales = new System.Windows.Forms.CheckBox();
            this.buttonRestorePreviousTree = new System.Windows.Forms.Button();
            this.textBoxMostInterstedFilterCount = new System.Windows.Forms.TextBox();
            this.checkBoxFilterByHiking = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterByMostInterestedCount = new System.Windows.Forms.CheckBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.cliqueMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isAnalyzedLabel2 = new System.Windows.Forms.Label();
            this.mostInterestLabel2 = new System.Windows.Forms.Label();
            this.buttonAnalyzeAllCliques = new System.Windows.Forms.Button();
            this.buttonAnalyzeClique = new System.Windows.Forms.Button();
            this.treeViewCliques = new System.Windows.Forms.TreeView();
            this.buttonMakeCliques = new System.Windows.Forms.Button();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.groupBoxExportDestination = new System.Windows.Forms.GroupBox();
            this.textBoxLocalDisPath = new System.Windows.Forms.TextBox();
            this.groupBoxExportFormats = new System.Windows.Forms.GroupBox();
            this.checkBoxExportText = new System.Windows.Forms.CheckBox();
            this.checkBoxExportXml = new System.Windows.Forms.CheckBox();
            this.groupBoxExportOptions = new System.Windows.Forms.GroupBox();
            this.listBoxExportSpecificClique = new System.Windows.Forms.ListBox();
            this.checkBoxExportEverything = new System.Windows.Forms.CheckBox();
            this.checkBoxExportSpecificClique = new System.Windows.Forms.CheckBox();
            this.buttonExport = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            dominantGenderLabel = new System.Windows.Forms.Label();
            femaleCountLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            isAnalyzedLabel = new System.Windows.Forms.Label();
            malesCountLabel = new System.Windows.Forms.Label();
            membersCountLabel = new System.Windows.Forms.Label();
            mostInterestLabel = new System.Windows.Forms.Label();
            mostInterestMembersCountLabel = new System.Windows.Forms.Label();
            rankLabel = new System.Windows.Forms.Label();
            isAnalyzedLabel1 = new System.Windows.Forms.Label();
            mostInterestLabel1 = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendImage)).BeginInit();
            this.tabControl.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.Posts.SuspendLayout();
            this.groupBoxPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.groupBoxUserGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageCliques.SuspendLayout();
            this.groupBoxAnalayze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliquesBindingSource)).BeginInit();
            this.groupBoxCliquesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliqueMembersBindingSource)).BeginInit();
            this.tabPageExport.SuspendLayout();
            this.groupBoxExportDestination.SuspendLayout();
            this.groupBoxExportFormats.SuspendLayout();
            this.groupBoxExportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            descriptionLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(5, 576);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(294, 40);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Description:";
            descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dominantGenderLabel
            // 
            dominantGenderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dominantGenderLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dominantGenderLabel.Location = new System.Drawing.Point(7, 98);
            dominantGenderLabel.Name = "dominantGenderLabel";
            dominantGenderLabel.Size = new System.Drawing.Size(294, 40);
            dominantGenderLabel.TabIndex = 19;
            dominantGenderLabel.Text = "Dominant Gender:";
            dominantGenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // femaleCountLabel
            // 
            femaleCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            femaleCountLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            femaleCountLabel.Location = new System.Drawing.Point(5, 209);
            femaleCountLabel.Name = "femaleCountLabel";
            femaleCountLabel.Size = new System.Drawing.Size(294, 40);
            femaleCountLabel.TabIndex = 21;
            femaleCountLabel.Text = "Female Count:";
            femaleCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iDLabel
            // 
            iDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iDLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(7, 46);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(294, 40);
            iDLabel.TabIndex = 23;
            iDLabel.Text = "ID:";
            iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isAnalyzedLabel
            // 
            isAnalyzedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            isAnalyzedLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isAnalyzedLabel.Location = new System.Drawing.Point(7, 150);
            isAnalyzedLabel.Name = "isAnalyzedLabel";
            isAnalyzedLabel.Size = new System.Drawing.Size(294, 40);
            isAnalyzedLabel.TabIndex = 25;
            isAnalyzedLabel.Text = "is Analyzed:";
            isAnalyzedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // malesCountLabel
            // 
            malesCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            malesCountLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            malesCountLabel.Location = new System.Drawing.Point(5, 265);
            malesCountLabel.Name = "malesCountLabel";
            malesCountLabel.Size = new System.Drawing.Size(294, 40);
            malesCountLabel.TabIndex = 27;
            malesCountLabel.Text = "Males Count:";
            malesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // membersCountLabel
            // 
            membersCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            membersCountLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            membersCountLabel.Location = new System.Drawing.Point(5, 320);
            membersCountLabel.Name = "membersCountLabel";
            membersCountLabel.Size = new System.Drawing.Size(294, 40);
            membersCountLabel.TabIndex = 29;
            membersCountLabel.Text = "Members Count:";
            membersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mostInterestLabel
            // 
            mostInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mostInterestLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostInterestLabel.Location = new System.Drawing.Point(5, 377);
            mostInterestLabel.Name = "mostInterestLabel";
            mostInterestLabel.Size = new System.Drawing.Size(294, 40);
            mostInterestLabel.TabIndex = 31;
            mostInterestLabel.Text = "Most Interest:";
            mostInterestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mostInterestMembersCountLabel
            // 
            mostInterestMembersCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mostInterestMembersCountLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostInterestMembersCountLabel.Location = new System.Drawing.Point(7, 431);
            mostInterestMembersCountLabel.Name = "mostInterestMembersCountLabel";
            mostInterestMembersCountLabel.Size = new System.Drawing.Size(294, 66);
            mostInterestMembersCountLabel.TabIndex = 33;
            mostInterestMembersCountLabel.Text = "Most Interest \r\nMembers Count:";
            mostInterestMembersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rankLabel
            // 
            rankLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            rankLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rankLabel.Location = new System.Drawing.Point(7, 521);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new System.Drawing.Size(294, 40);
            rankLabel.TabIndex = 35;
            rankLabel.Text = "Rank:";
            rankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isAnalyzedLabel1
            // 
            isAnalyzedLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            isAnalyzedLabel1.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isAnalyzedLabel1.Location = new System.Drawing.Point(391, 352);
            isAnalyzedLabel1.Name = "isAnalyzedLabel1";
            isAnalyzedLabel1.Size = new System.Drawing.Size(199, 65);
            isAnalyzedLabel1.TabIndex = 4;
            isAnalyzedLabel1.Text = "Is Analyzed:";
            isAnalyzedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mostInterestLabel1
            // 
            mostInterestLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mostInterestLabel1.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostInterestLabel1.Location = new System.Drawing.Point(391, 431);
            mostInterestLabel1.Name = "mostInterestLabel1";
            mostInterestLabel1.Size = new System.Drawing.Size(199, 66);
            mostInterestLabel1.TabIndex = 6;
            mostInterestLabel1.Text = "Most Interest:";
            mostInterestLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            imageNormalLabel.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageNormalLabel.Location = new System.Drawing.Point(391, 146);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(199, 200);
            imageNormalLabel.TabIndex = 8;
            imageNormalLabel.Text = "Image Normal:";
            imageNormalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(316, 55);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(251, 250);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(27, 36);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 62);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Narkisim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelUserName.Location = new System.Drawing.Point(27, 82);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(200, 199);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeViewFriends
            // 
            this.treeViewFriends.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFriends.Location = new System.Drawing.Point(7, 114);
            this.treeViewFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewFriends.Name = "treeViewFriends";
            this.treeViewFriends.Size = new System.Drawing.Size(387, 308);
            this.treeViewFriends.TabIndex = 4;
            this.treeViewFriends.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFriends_NodeMouseClick);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchFriends.Location = new System.Drawing.Point(7, 34);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(200, 62);
            this.buttonFetchFriends.TabIndex = 1;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // labelFriendImage
            // 
            this.labelFriendImage.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendImage.Location = new System.Drawing.Point(436, 124);
            this.labelFriendImage.Name = "labelFriendImage";
            this.labelFriendImage.Size = new System.Drawing.Size(139, 86);
            this.labelFriendImage.TabIndex = 3;
            this.labelFriendImage.Text = "Friend Profile Picture";
            // 
            // pictureBoxFriendImage
            // 
            this.pictureBoxFriendImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFriendImage.Location = new System.Drawing.Point(420, 246);
            this.pictureBoxFriendImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriendImage.Name = "pictureBoxFriendImage";
            this.pictureBoxFriendImage.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxFriendImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendImage.TabIndex = 0;
            this.pictureBoxFriendImage.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.HomePage);
            this.tabControl.Controls.Add(this.tabPageCliques);
            this.tabControl.Controls.Add(this.tabPageExport);
            this.tabControl.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 14);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1485, 892);
            this.tabControl.TabIndex = 5;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.groupBoxLogin);
            this.HomePage.Controls.Add(this.Posts);
            this.HomePage.Controls.Add(this.groupBoxPages);
            this.HomePage.Controls.Add(this.groupBoxUserGroups);
            this.HomePage.Controls.Add(this.groupBox1);
            this.HomePage.ForeColor = System.Drawing.Color.Black;
            this.HomePage.Location = new System.Drawing.Point(4, 44);
            this.HomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePage.Size = new System.Drawing.Size(1477, 844);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "HomePage";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxToken);
            this.groupBoxLogin.Controls.Add(this.checkBoxLogin);
            this.groupBoxLogin.Controls.Add(this.checkBoxLoginToken);
            this.groupBoxLogin.Controls.Add(this.pictureBoxProfilePicture);
            this.groupBoxLogin.Controls.Add(this.labelUserName);
            this.groupBoxLogin.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(33, 31);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Size = new System.Drawing.Size(596, 345);
            this.groupBoxLogin.TabIndex = 7;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(321, 161);
            this.textBoxToken.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(231, 31);
            this.textBoxToken.TabIndex = 6;
            // 
            // checkBoxLogin
            // 
            this.checkBoxLogin.AutoSize = true;
            this.checkBoxLogin.Location = new System.Drawing.Point(27, 230);
            this.checkBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLogin.Name = "checkBoxLogin";
            this.checkBoxLogin.Size = new System.Drawing.Size(265, 28);
            this.checkBoxLogin.TabIndex = 5;
            this.checkBoxLogin.Text = "Login With Credentials";
            this.checkBoxLogin.UseVisualStyleBackColor = true;
            this.checkBoxLogin.CheckedChanged += new System.EventHandler(this.checkBoxLogin_CheckedChanged);
            // 
            // checkBoxLoginToken
            // 
            this.checkBoxLoginToken.AutoSize = true;
            this.checkBoxLoginToken.Location = new System.Drawing.Point(27, 161);
            this.checkBoxLoginToken.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLoginToken.Name = "checkBoxLoginToken";
            this.checkBoxLoginToken.Size = new System.Drawing.Size(215, 28);
            this.checkBoxLoginToken.TabIndex = 4;
            this.checkBoxLoginToken.Text = "Login With Token";
            this.checkBoxLoginToken.UseVisualStyleBackColor = true;
            this.checkBoxLoginToken.CheckedChanged += new System.EventHandler(this.checkBoxLoginToken_CheckedChanged);
            // 
            // Posts
            // 
            this.Posts.Controls.Add(this.listBoxPosts);
            this.Posts.Controls.Add(this.buttonFetchPosts);
            this.Posts.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Posts.Location = new System.Drawing.Point(663, 31);
            this.Posts.Margin = new System.Windows.Forms.Padding(4);
            this.Posts.Name = "Posts";
            this.Posts.Padding = new System.Windows.Forms.Padding(4);
            this.Posts.Size = new System.Drawing.Size(773, 345);
            this.Posts.TabIndex = 6;
            this.Posts.TabStop = false;
            this.Posts.Text = "Posts";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.ColumnWidth = 20;
            this.listBoxPosts.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(8, 124);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(752, 196);
            this.listBoxPosts.TabIndex = 0;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchPosts.Location = new System.Drawing.Point(8, 34);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(200, 60);
            this.buttonFetchPosts.TabIndex = 1;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // groupBoxPages
            // 
            this.groupBoxPages.Controls.Add(this.listBoxPages);
            this.groupBoxPages.Controls.Add(this.pictureBoxPage);
            this.groupBoxPages.Controls.Add(this.buttonPages);
            this.groupBoxPages.Controls.Add(this.labelPages);
            this.groupBoxPages.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPages.Location = new System.Drawing.Point(1072, 383);
            this.groupBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPages.Name = "groupBoxPages";
            this.groupBoxPages.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPages.Size = new System.Drawing.Size(364, 437);
            this.groupBoxPages.TabIndex = 5;
            this.groupBoxPages.TabStop = false;
            this.groupBoxPages.Text = "Pages";
            // 
            // listBoxPages
            // 
            this.listBoxPages.ColumnWidth = 20;
            this.listBoxPages.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(8, 114);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(197, 308);
            this.listBoxPages.TabIndex = 0;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage.Location = new System.Drawing.Point(219, 235);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage.TabIndex = 0;
            this.pictureBoxPage.TabStop = false;
            // 
            // buttonPages
            // 
            this.buttonPages.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPages.Location = new System.Drawing.Point(7, 34);
            this.buttonPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPages.Name = "buttonPages";
            this.buttonPages.Size = new System.Drawing.Size(200, 62);
            this.buttonPages.TabIndex = 1;
            this.buttonPages.Text = "Fetch Pages";
            this.buttonPages.UseVisualStyleBackColor = true;
            this.buttonPages.Click += new System.EventHandler(this.buttonPages_Click);
            // 
            // labelPages
            // 
            this.labelPages.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPages.Location = new System.Drawing.Point(213, 124);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(139, 86);
            this.labelPages.TabIndex = 3;
            this.labelPages.Text = "Page Picture";
            // 
            // groupBoxUserGroups
            // 
            this.groupBoxUserGroups.Controls.Add(this.listBoxGroups);
            this.groupBoxUserGroups.Controls.Add(this.pictureBoxGroup);
            this.groupBoxUserGroups.Controls.Add(this.buttonFetchGroups);
            this.groupBoxUserGroups.Controls.Add(this.labelGroups);
            this.groupBoxUserGroups.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserGroups.Location = new System.Drawing.Point(663, 383);
            this.groupBoxUserGroups.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUserGroups.Name = "groupBoxUserGroups";
            this.groupBoxUserGroups.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUserGroups.Size = new System.Drawing.Size(364, 437);
            this.groupBoxUserGroups.TabIndex = 5;
            this.groupBoxUserGroups.TabStop = false;
            this.groupBoxUserGroups.Text = "Groups";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.ColumnWidth = 20;
            this.listBoxGroups.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(8, 114);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(197, 308);
            this.listBoxGroups.TabIndex = 0;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGroup.Location = new System.Drawing.Point(219, 235);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroup.TabIndex = 0;
            this.pictureBoxGroup.TabStop = false;
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchGroups.Location = new System.Drawing.Point(7, 34);
            this.buttonFetchGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(200, 62);
            this.buttonFetchGroups.TabIndex = 1;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // labelGroups
            // 
            this.labelGroups.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroups.Location = new System.Drawing.Point(213, 124);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(139, 86);
            this.labelGroups.TabIndex = 3;
            this.labelGroups.Text = "Group Picture";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxFriendImage);
            this.groupBox1.Controls.Add(this.buttonFetchFriends);
            this.groupBox1.Controls.Add(this.treeViewFriends);
            this.groupBox1.Controls.Add(this.labelFriendImage);
            this.groupBox1.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 383);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(596, 437);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Friends";
            // 
            // tabPageCliques
            // 
            this.tabPageCliques.AutoScroll = true;
            this.tabPageCliques.Controls.Add(this.groupBoxAnalayze);
            this.tabPageCliques.Controls.Add(this.groupBoxCliquesInfo);
            this.tabPageCliques.Location = new System.Drawing.Point(4, 44);
            this.tabPageCliques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCliques.Name = "tabPageCliques";
            this.tabPageCliques.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCliques.Size = new System.Drawing.Size(1477, 844);
            this.tabPageCliques.TabIndex = 1;
            this.tabPageCliques.Text = "Cliques Anlysis";
            this.tabPageCliques.UseVisualStyleBackColor = true;
            // 
            // groupBoxAnalayze
            // 
            this.groupBoxAnalayze.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAnalayze.Controls.Add(dominantGenderLabel);
            this.groupBoxAnalayze.Controls.Add(this.dominantGenderLabelValue);
            this.groupBoxAnalayze.Controls.Add(femaleCountLabel);
            this.groupBoxAnalayze.Controls.Add(this.femaleCountLabelValue);
            this.groupBoxAnalayze.Controls.Add(iDLabel);
            this.groupBoxAnalayze.Controls.Add(this.iDLabelValue);
            this.groupBoxAnalayze.Controls.Add(isAnalyzedLabel);
            this.groupBoxAnalayze.Controls.Add(this.isAnalyzedLabelValue);
            this.groupBoxAnalayze.Controls.Add(malesCountLabel);
            this.groupBoxAnalayze.Controls.Add(this.malesCountLabelValue);
            this.groupBoxAnalayze.Controls.Add(membersCountLabel);
            this.groupBoxAnalayze.Controls.Add(this.membersCountLabelValue);
            this.groupBoxAnalayze.Controls.Add(mostInterestLabel);
            this.groupBoxAnalayze.Controls.Add(this.mostInterestLabelValue);
            this.groupBoxAnalayze.Controls.Add(mostInterestMembersCountLabel);
            this.groupBoxAnalayze.Controls.Add(this.mostInterestMembersCountLabelValue);
            this.groupBoxAnalayze.Controls.Add(rankLabel);
            this.groupBoxAnalayze.Controls.Add(this.rankLabelValue);
            this.groupBoxAnalayze.Controls.Add(descriptionLabel);
            this.groupBoxAnalayze.Controls.Add(this.descriptionTextBox);
            this.groupBoxAnalayze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnalayze.Location = new System.Drawing.Point(835, 6);
            this.groupBoxAnalayze.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAnalayze.Name = "groupBoxAnalayze";
            this.groupBoxAnalayze.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAnalayze.Size = new System.Drawing.Size(625, 832);
            this.groupBoxAnalayze.TabIndex = 5;
            this.groupBoxAnalayze.TabStop = false;
            this.groupBoxAnalayze.Text = "Cliques Info";
            // 
            // dominantGenderLabelValue
            // 
            this.dominantGenderLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dominantGenderLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.DominantGender", true));
            this.dominantGenderLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dominantGenderLabelValue.Location = new System.Drawing.Point(323, 97);
            this.dominantGenderLabelValue.Name = "dominantGenderLabelValue";
            this.dominantGenderLabelValue.Size = new System.Drawing.Size(283, 40);
            this.dominantGenderLabelValue.TabIndex = 20;
            this.dominantGenderLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cliquesBindingSource
            // 
            this.cliquesBindingSource.DataSource = typeof(System.Collections.Generic.KeyValuePair<int, Logic.Clique>);
            // 
            // femaleCountLabelValue
            // 
            this.femaleCountLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.femaleCountLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.FemaleCount", true));
            this.femaleCountLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleCountLabelValue.Location = new System.Drawing.Point(323, 209);
            this.femaleCountLabelValue.Name = "femaleCountLabelValue";
            this.femaleCountLabelValue.Size = new System.Drawing.Size(283, 40);
            this.femaleCountLabelValue.TabIndex = 22;
            this.femaleCountLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iDLabelValue
            // 
            this.iDLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.ID", true));
            this.iDLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabelValue.Location = new System.Drawing.Point(323, 46);
            this.iDLabelValue.Name = "iDLabelValue";
            this.iDLabelValue.Size = new System.Drawing.Size(283, 40);
            this.iDLabelValue.TabIndex = 24;
            this.iDLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isAnalyzedLabelValue
            // 
            this.isAnalyzedLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isAnalyzedLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.isAnalyzed", true));
            this.isAnalyzedLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAnalyzedLabelValue.Location = new System.Drawing.Point(323, 150);
            this.isAnalyzedLabelValue.Name = "isAnalyzedLabelValue";
            this.isAnalyzedLabelValue.Size = new System.Drawing.Size(283, 40);
            this.isAnalyzedLabelValue.TabIndex = 26;
            this.isAnalyzedLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // malesCountLabelValue
            // 
            this.malesCountLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.malesCountLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.MalesCount", true));
            this.malesCountLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malesCountLabelValue.Location = new System.Drawing.Point(323, 263);
            this.malesCountLabelValue.Name = "malesCountLabelValue";
            this.malesCountLabelValue.Size = new System.Drawing.Size(283, 40);
            this.malesCountLabelValue.TabIndex = 28;
            this.malesCountLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // membersCountLabelValue
            // 
            this.membersCountLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membersCountLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.MembersCount", true));
            this.membersCountLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersCountLabelValue.Location = new System.Drawing.Point(323, 319);
            this.membersCountLabelValue.Name = "membersCountLabelValue";
            this.membersCountLabelValue.Size = new System.Drawing.Size(283, 40);
            this.membersCountLabelValue.TabIndex = 30;
            this.membersCountLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mostInterestLabelValue
            // 
            this.mostInterestLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostInterestLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.MostInterest", true));
            this.mostInterestLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostInterestLabelValue.Location = new System.Drawing.Point(323, 377);
            this.mostInterestLabelValue.Name = "mostInterestLabelValue";
            this.mostInterestLabelValue.Size = new System.Drawing.Size(283, 40);
            this.mostInterestLabelValue.TabIndex = 32;
            this.mostInterestLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mostInterestMembersCountLabelValue
            // 
            this.mostInterestMembersCountLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostInterestMembersCountLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.MostInterestMembersCount", true));
            this.mostInterestMembersCountLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostInterestMembersCountLabelValue.Location = new System.Drawing.Point(323, 431);
            this.mostInterestMembersCountLabelValue.Name = "mostInterestMembersCountLabelValue";
            this.mostInterestMembersCountLabelValue.Size = new System.Drawing.Size(283, 66);
            this.mostInterestMembersCountLabelValue.TabIndex = 34;
            this.mostInterestMembersCountLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankLabelValue
            // 
            this.rankLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankLabelValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.Rank", true));
            this.rankLabelValue.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabelValue.Location = new System.Drawing.Point(323, 519);
            this.rankLabelValue.Name = "rankLabelValue";
            this.rankLabelValue.Size = new System.Drawing.Size(283, 40);
            this.rankLabelValue.TabIndex = 36;
            this.rankLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliquesBindingSource, "Value.Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.descriptionTextBox.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(323, 576);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(283, 248);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // groupBoxCliquesInfo
            // 
            this.groupBoxCliquesInfo.Controls.Add(this.checkBoxDisplayOnlyFemales);
            this.groupBoxCliquesInfo.Controls.Add(this.buttonRestorePreviousTree);
            this.groupBoxCliquesInfo.Controls.Add(this.textBoxMostInterstedFilterCount);
            this.groupBoxCliquesInfo.Controls.Add(this.checkBoxFilterByHiking);
            this.groupBoxCliquesInfo.Controls.Add(this.checkBoxFilterByMostInterestedCount);
            this.groupBoxCliquesInfo.Controls.Add(imageNormalLabel);
            this.groupBoxCliquesInfo.Controls.Add(this.imageNormalPictureBox);
            this.groupBoxCliquesInfo.Controls.Add(isAnalyzedLabel1);
            this.groupBoxCliquesInfo.Controls.Add(this.isAnalyzedLabel2);
            this.groupBoxCliquesInfo.Controls.Add(mostInterestLabel1);
            this.groupBoxCliquesInfo.Controls.Add(this.mostInterestLabel2);
            this.groupBoxCliquesInfo.Controls.Add(this.buttonAnalyzeAllCliques);
            this.groupBoxCliquesInfo.Controls.Add(this.buttonAnalyzeClique);
            this.groupBoxCliquesInfo.Controls.Add(this.treeViewCliques);
            this.groupBoxCliquesInfo.Controls.Add(this.buttonMakeCliques);
            this.groupBoxCliquesInfo.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCliquesInfo.Location = new System.Drawing.Point(7, 6);
            this.groupBoxCliquesInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCliquesInfo.Name = "groupBoxCliquesInfo";
            this.groupBoxCliquesInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCliquesInfo.Size = new System.Drawing.Size(819, 832);
            this.groupBoxCliquesInfo.TabIndex = 4;
            this.groupBoxCliquesInfo.TabStop = false;
            this.groupBoxCliquesInfo.Text = "Cliques Tree";
            // 
            // checkBoxDisplayOnlyFemales
            // 
            this.checkBoxDisplayOnlyFemales.AutoSize = true;
            this.checkBoxDisplayOnlyFemales.Location = new System.Drawing.Point(393, 650);
            this.checkBoxDisplayOnlyFemales.Name = "checkBoxDisplayOnlyFemales";
            this.checkBoxDisplayOnlyFemales.Size = new System.Drawing.Size(251, 28);
            this.checkBoxDisplayOnlyFemales.TabIndex = 15;
            this.checkBoxDisplayOnlyFemales.Text = "Display Only Females";
            this.checkBoxDisplayOnlyFemales.UseVisualStyleBackColor = true;
            this.checkBoxDisplayOnlyFemales.CheckedChanged += new System.EventHandler(this.checkBoxDisplayOnlyFemales_CheckedChanged);
            // 
            // buttonRestorePreviousTree
            // 
            this.buttonRestorePreviousTree.Font = new System.Drawing.Font("Narkisim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestorePreviousTree.Location = new System.Drawing.Point(481, 714);
            this.buttonRestorePreviousTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestorePreviousTree.Name = "buttonRestorePreviousTree";
            this.buttonRestorePreviousTree.Size = new System.Drawing.Size(251, 100);
            this.buttonRestorePreviousTree.TabIndex = 14;
            this.buttonRestorePreviousTree.Text = "Restore";
            this.buttonRestorePreviousTree.UseVisualStyleBackColor = true;
            this.buttonRestorePreviousTree.Click += new System.EventHandler(this.buttonRestorePreviousTree_Click);
            // 
            // textBoxMostInterstedFilterCount
            // 
            this.textBoxMostInterstedFilterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMostInterstedFilterCount.Font = new System.Drawing.Font("Narkisim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMostInterstedFilterCount.Location = new System.Drawing.Point(604, 512);
            this.textBoxMostInterstedFilterCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMostInterstedFilterCount.Multiline = true;
            this.textBoxMostInterstedFilterCount.Name = "textBoxMostInterstedFilterCount";
            this.textBoxMostInterstedFilterCount.Size = new System.Drawing.Size(176, 58);
            this.textBoxMostInterstedFilterCount.TabIndex = 13;
            this.textBoxMostInterstedFilterCount.Text = "Type count here";
            this.textBoxMostInterstedFilterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxFilterByHiking
            // 
            this.checkBoxFilterByHiking.AutoSize = true;
            this.checkBoxFilterByHiking.Font = new System.Drawing.Font("Narkisim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFilterByHiking.Location = new System.Drawing.Point(391, 590);
            this.checkBoxFilterByHiking.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFilterByHiking.Name = "checkBoxFilterByHiking";
            this.checkBoxFilterByHiking.Size = new System.Drawing.Size(413, 31);
            this.checkBoxFilterByHiking.TabIndex = 12;
            this.checkBoxFilterByHiking.Text = "Filter by most intereted in Hiking";
            this.checkBoxFilterByHiking.UseVisualStyleBackColor = true;
            this.checkBoxFilterByHiking.CheckedChanged += new System.EventHandler(this.checkBoxFilterByHiking_CheckedChanged);
            // 
            // checkBoxFilterByMostInterestedCount
            // 
            this.checkBoxFilterByMostInterestedCount.AutoSize = true;
            this.checkBoxFilterByMostInterestedCount.Font = new System.Drawing.Font("Narkisim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFilterByMostInterestedCount.Location = new System.Drawing.Point(393, 512);
            this.checkBoxFilterByMostInterestedCount.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFilterByMostInterestedCount.Name = "checkBoxFilterByMostInterestedCount";
            this.checkBoxFilterByMostInterestedCount.Size = new System.Drawing.Size(203, 58);
            this.checkBoxFilterByMostInterestedCount.TabIndex = 10;
            this.checkBoxFilterByMostInterestedCount.Text = "Filter By Most \r\nInterest Count";
            this.checkBoxFilterByMostInterestedCount.UseVisualStyleBackColor = true;
            this.checkBoxFilterByMostInterestedCount.CheckedChanged += new System.EventHandler(this.checkBoxFilterByMostInterestedCount_CheckedChanged);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cliqueMembersBindingSource, "Value.FetchedUser.ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(597, 146);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(199, 200);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 9;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // cliqueMembersBindingSource
            // 
            this.cliqueMembersBindingSource.DataSource = typeof(System.Collections.Generic.KeyValuePair<int, Logic.Member>);
            // 
            // isAnalyzedLabel2
            // 
            this.isAnalyzedLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isAnalyzedLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliqueMembersBindingSource, "Value.IsAnalyzed", true));
            this.isAnalyzedLabel2.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAnalyzedLabel2.Location = new System.Drawing.Point(596, 352);
            this.isAnalyzedLabel2.Name = "isAnalyzedLabel2";
            this.isAnalyzedLabel2.Size = new System.Drawing.Size(199, 65);
            this.isAnalyzedLabel2.TabIndex = 5;
            this.isAnalyzedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mostInterestLabel2
            // 
            this.mostInterestLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostInterestLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cliqueMembersBindingSource, "Value.MostInterest", true));
            this.mostInterestLabel2.Font = new System.Drawing.Font("Narkisim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostInterestLabel2.Location = new System.Drawing.Point(596, 431);
            this.mostInterestLabel2.Name = "mostInterestLabel2";
            this.mostInterestLabel2.Size = new System.Drawing.Size(199, 66);
            this.mostInterestLabel2.TabIndex = 7;
            this.mostInterestLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAnalyzeAllCliques
            // 
            this.buttonAnalyzeAllCliques.Font = new System.Drawing.Font("Narkisim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalyzeAllCliques.Location = new System.Drawing.Point(547, 30);
            this.buttonAnalyzeAllCliques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnalyzeAllCliques.Name = "buttonAnalyzeAllCliques";
            this.buttonAnalyzeAllCliques.Size = new System.Drawing.Size(251, 100);
            this.buttonAnalyzeAllCliques.TabIndex = 2;
            this.buttonAnalyzeAllCliques.Text = "Analyze All";
            this.buttonAnalyzeAllCliques.UseVisualStyleBackColor = true;
            this.buttonAnalyzeAllCliques.Click += new System.EventHandler(this.buttonAnalyzeAllCliques_Click);
            // 
            // buttonAnalyzeClique
            // 
            this.buttonAnalyzeClique.Font = new System.Drawing.Font("Narkisim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalyzeClique.Location = new System.Drawing.Point(277, 30);
            this.buttonAnalyzeClique.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnalyzeClique.Name = "buttonAnalyzeClique";
            this.buttonAnalyzeClique.Size = new System.Drawing.Size(251, 100);
            this.buttonAnalyzeClique.TabIndex = 2;
            this.buttonAnalyzeClique.Text = "Analyze Clique";
            this.buttonAnalyzeClique.UseVisualStyleBackColor = true;
            this.buttonAnalyzeClique.Click += new System.EventHandler(this.buttonAnalyzeClique_Click);
            // 
            // treeViewCliques
            // 
            this.treeViewCliques.Location = new System.Drawing.Point(8, 146);
            this.treeViewCliques.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewCliques.Name = "treeViewCliques";
            this.treeViewCliques.Size = new System.Drawing.Size(376, 677);
            this.treeViewCliques.TabIndex = 3;
            this.treeViewCliques.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCliques_AfterSelect);
            // 
            // buttonMakeCliques
            // 
            this.buttonMakeCliques.Font = new System.Drawing.Font("Narkisim", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakeCliques.Location = new System.Drawing.Point(8, 30);
            this.buttonMakeCliques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMakeCliques.Name = "buttonMakeCliques";
            this.buttonMakeCliques.Size = new System.Drawing.Size(251, 100);
            this.buttonMakeCliques.TabIndex = 2;
            this.buttonMakeCliques.Text = "Make Cliques";
            this.buttonMakeCliques.UseVisualStyleBackColor = true;
            this.buttonMakeCliques.Click += new System.EventHandler(this.buttonMakeCliques_Click);
            // 
            // tabPageExport
            // 
            this.tabPageExport.Controls.Add(this.groupBoxExportDestination);
            this.tabPageExport.Controls.Add(this.groupBoxExportFormats);
            this.tabPageExport.Controls.Add(this.groupBoxExportOptions);
            this.tabPageExport.Controls.Add(this.buttonExport);
            this.tabPageExport.Location = new System.Drawing.Point(4, 44);
            this.tabPageExport.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageExport.Size = new System.Drawing.Size(1477, 844);
            this.tabPageExport.TabIndex = 2;
            this.tabPageExport.Text = "Export Results";
            this.tabPageExport.UseVisualStyleBackColor = true;
            // 
            // groupBoxExportDestination
            // 
            this.groupBoxExportDestination.Controls.Add(this.textBoxLocalDisPath);
            this.groupBoxExportDestination.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExportDestination.Location = new System.Drawing.Point(977, 90);
            this.groupBoxExportDestination.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExportDestination.Name = "groupBoxExportDestination";
            this.groupBoxExportDestination.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxExportDestination.Size = new System.Drawing.Size(444, 428);
            this.groupBoxExportDestination.TabIndex = 5;
            this.groupBoxExportDestination.TabStop = false;
            this.groupBoxExportDestination.Text = "Export Destination";
            // 
            // textBoxLocalDisPath
            // 
            this.textBoxLocalDisPath.Location = new System.Drawing.Point(21, 60);
            this.textBoxLocalDisPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocalDisPath.Multiline = true;
            this.textBoxLocalDisPath.Name = "textBoxLocalDisPath";
            this.textBoxLocalDisPath.Size = new System.Drawing.Size(397, 347);
            this.textBoxLocalDisPath.TabIndex = 3;
            // 
            // groupBoxExportFormats
            // 
            this.groupBoxExportFormats.Controls.Add(this.checkBoxExportText);
            this.groupBoxExportFormats.Controls.Add(this.checkBoxExportXml);
            this.groupBoxExportFormats.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExportFormats.Location = new System.Drawing.Point(669, 90);
            this.groupBoxExportFormats.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExportFormats.Name = "groupBoxExportFormats";
            this.groupBoxExportFormats.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxExportFormats.Size = new System.Drawing.Size(281, 428);
            this.groupBoxExportFormats.TabIndex = 4;
            this.groupBoxExportFormats.TabStop = false;
            this.groupBoxExportFormats.Text = "Export Formats";
            // 
            // checkBoxExportText
            // 
            this.checkBoxExportText.AutoSize = true;
            this.checkBoxExportText.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExportText.Location = new System.Drawing.Point(81, 130);
            this.checkBoxExportText.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExportText.Name = "checkBoxExportText";
            this.checkBoxExportText.Size = new System.Drawing.Size(84, 38);
            this.checkBoxExportText.TabIndex = 1;
            this.checkBoxExportText.Text = ".txt";
            this.checkBoxExportText.UseVisualStyleBackColor = true;
            // 
            // checkBoxExportXml
            // 
            this.checkBoxExportXml.AutoSize = true;
            this.checkBoxExportXml.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExportXml.Location = new System.Drawing.Point(81, 286);
            this.checkBoxExportXml.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExportXml.Name = "checkBoxExportXml";
            this.checkBoxExportXml.Size = new System.Drawing.Size(97, 38);
            this.checkBoxExportXml.TabIndex = 1;
            this.checkBoxExportXml.Text = ".xml";
            this.checkBoxExportXml.UseVisualStyleBackColor = true;
            // 
            // groupBoxExportOptions
            // 
            this.groupBoxExportOptions.Controls.Add(this.listBoxExportSpecificClique);
            this.groupBoxExportOptions.Controls.Add(this.checkBoxExportEverything);
            this.groupBoxExportOptions.Controls.Add(this.checkBoxExportSpecificClique);
            this.groupBoxExportOptions.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExportOptions.Location = new System.Drawing.Point(21, 90);
            this.groupBoxExportOptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExportOptions.Name = "groupBoxExportOptions";
            this.groupBoxExportOptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxExportOptions.Size = new System.Drawing.Size(612, 428);
            this.groupBoxExportOptions.TabIndex = 3;
            this.groupBoxExportOptions.TabStop = false;
            this.groupBoxExportOptions.Text = "Export Options";
            // 
            // listBoxExportSpecificClique
            // 
            this.listBoxExportSpecificClique.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExportSpecificClique.FormattingEnabled = true;
            this.listBoxExportSpecificClique.ItemHeight = 34;
            this.listBoxExportSpecificClique.Location = new System.Drawing.Point(32, 204);
            this.listBoxExportSpecificClique.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxExportSpecificClique.Name = "listBoxExportSpecificClique";
            this.listBoxExportSpecificClique.Size = new System.Drawing.Size(551, 140);
            this.listBoxExportSpecificClique.TabIndex = 2;
            // 
            // checkBoxExportEverything
            // 
            this.checkBoxExportEverything.AutoSize = true;
            this.checkBoxExportEverything.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExportEverything.Location = new System.Drawing.Point(32, 60);
            this.checkBoxExportEverything.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExportEverything.Name = "checkBoxExportEverything";
            this.checkBoxExportEverything.Size = new System.Drawing.Size(287, 38);
            this.checkBoxExportEverything.TabIndex = 1;
            this.checkBoxExportEverything.Text = "Export Everything";
            this.checkBoxExportEverything.UseVisualStyleBackColor = true;
            this.checkBoxExportEverything.CheckedChanged += new System.EventHandler(this.checkBoxExportEverything_CheckedChanged);
            // 
            // checkBoxExportSpecificClique
            // 
            this.checkBoxExportSpecificClique.AutoSize = true;
            this.checkBoxExportSpecificClique.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExportSpecificClique.Location = new System.Drawing.Point(32, 128);
            this.checkBoxExportSpecificClique.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExportSpecificClique.Name = "checkBoxExportSpecificClique";
            this.checkBoxExportSpecificClique.Size = new System.Drawing.Size(346, 38);
            this.checkBoxExportSpecificClique.TabIndex = 1;
            this.checkBoxExportSpecificClique.Text = "Export Specific Clique";
            this.checkBoxExportSpecificClique.UseVisualStyleBackColor = true;
            this.checkBoxExportSpecificClique.CheckedChanged += new System.EventHandler(this.checkBoxExportSpecificClique_CheckedChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(604, 591);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(267, 123);
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 917);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceBook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendImage)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.Posts.ResumeLayout(false);
            this.groupBoxPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.groupBoxUserGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPageCliques.ResumeLayout(false);
            this.groupBoxAnalayze.ResumeLayout(false);
            this.groupBoxAnalayze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliquesBindingSource)).EndInit();
            this.groupBoxCliquesInfo.ResumeLayout(false);
            this.groupBoxCliquesInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliqueMembersBindingSource)).EndInit();
            this.tabPageExport.ResumeLayout(false);
            this.groupBoxExportDestination.ResumeLayout(false);
            this.groupBoxExportDestination.PerformLayout();
            this.groupBoxExportFormats.ResumeLayout(false);
            this.groupBoxExportFormats.PerformLayout();
            this.groupBoxExportOptions.ResumeLayout(false);
            this.groupBoxExportOptions.PerformLayout();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TreeView treeViewFriends;
        private System.Windows.Forms.Button buttonFetchFriends;
        private Label labelFriendImage;
        private PictureBox pictureBoxFriendImage;
        private TabControl tabControl;
        private TabPage HomePage;
        private TabPage tabPageCliques;
        private Button buttonMakeCliques;
        private GroupBox groupBox1;
        private GroupBox Posts;
        private ListBox listBoxPosts;
        private Button buttonFetchPosts;
        private GroupBox groupBoxLogin;
        private GroupBox groupBoxCliquesInfo;
        private GroupBox groupBoxAnalayze;
        private TreeView treeViewCliques;
        private TabPage tabPageExport;
        private GroupBox groupBoxExportDestination;
        private GroupBox groupBoxExportFormats;
        private CheckBox checkBoxExportText;
        private CheckBox checkBoxExportXml;
        private GroupBox groupBoxExportOptions;
        private ListBox listBoxExportSpecificClique;
        private CheckBox checkBoxExportEverything;
        private CheckBox checkBoxExportSpecificClique;
        private Button buttonExport;
        private Button buttonAnalyzeClique;
        private GroupBox groupBoxUserGroups;
        private ListBox listBoxGroups;
        private PictureBox pictureBoxGroup;
        private Button buttonFetchGroups;
        private Label labelGroups;
        private GroupBox groupBoxPages;
        private ListBox listBoxPages;
        private PictureBox pictureBoxPage;
        private Button buttonPages;
        private Label labelPages;
        private Button buttonAnalyzeAllCliques;
        private TextBox textBoxLocalDisPath;
        private TextBox textBoxToken;
        private CheckBox checkBoxLogin;
        private CheckBox checkBoxLoginToken;
        private BindingSource cliquesBindingSource;
        private Label dominantGenderLabelValue;
        private Label femaleCountLabelValue;
        private Label iDLabelValue;
        private Label isAnalyzedLabelValue;
        private Label malesCountLabelValue;
        private Label membersCountLabelValue;
        private Label mostInterestLabelValue;
        private Label mostInterestMembersCountLabelValue;
        private Label rankLabelValue;
        private TextBox descriptionTextBox;
        private PictureBox imageNormalPictureBox;
        private BindingSource cliqueMembersBindingSource;
        private Label isAnalyzedLabel2;
        private Label mostInterestLabel2;
        private CheckBox checkBoxFilterByHiking;
        private CheckBox checkBoxFilterByMostInterestedCount;
        private TextBox textBoxMostInterstedFilterCount;
        private Button buttonRestorePreviousTree;
        private CheckBox checkBoxDisplayOnlyFemales;
    }
}

