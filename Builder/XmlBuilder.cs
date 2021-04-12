using System;
using System.Collections.Generic;
using Logic;
using System.IO;
using System.Xml.Linq;

namespace Builder
{
    public class XmlBuilder : ICliqueDocBuilder
    {

        public void CreateDoc(ICollection<Clique> i_GivenCliques, string i_FilePath)
        {
            XElement root = new XElement("Cliques");
            foreach (Clique clique in i_GivenCliques)
            {
                XElement cliqueNode = appendCliqueHeader(clique);
                XElement memberNode = appendCliqueMembers(clique);
                cliqueNode.Add(memberNode);
                root.Add(cliqueNode);
            }

            saveFile(i_FilePath, root);
        }
        
        public void CreateDoc(Clique i_Clique, string i_FilePath)
        {
            XElement root = new XElement("Cliques");
            XElement cliqueNode = appendCliqueHeader(i_Clique);
            XElement memberNode = appendCliqueMembers(i_Clique);
            cliqueNode.Add(memberNode);
            root.Add(cliqueNode);
            saveFile(i_FilePath, root);
        }        

        private XElement appendCliqueMembers(Clique clique)
        {
            XElement memberNode = new XElement("Members");
            foreach (Member member in clique.CliqueMembers.Values)
            {
                memberNode.Add(new XElement("Member", new XAttribute("Name", member.Name)));
            }

            return memberNode;
        }

        private XElement appendCliqueHeader(Clique clique)
        {
            return new XElement("Clique",
                                new XAttribute("ID", clique.ID.ToString()),
                                new XAttribute("MembersCount", clique.MembersCount.ToString()),
                                new XAttribute("MalesCount", clique.MalesCount.ToString()),
                                new XAttribute("FemaleCount", clique.FemaleCount.ToString()),
                                new XAttribute("MostInterest", clique.MostInterest.ToString()),
                                new XAttribute("DominantGender", clique.DominantGender),
                                new XAttribute("MostInterestMemberCount", clique.MostInterestMembersCount.ToString()),
                                new XAttribute("Rank", clique.Rank.ToString()),
                                new XAttribute("Description", clique.Description)

                                );
        }

        private void saveFile(string i_FilePath, XElement root)
        {
            try
            {
                root.Save(new FileStream(string.Format(@"{0}/export.xml", i_FilePath), FileMode.Create));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    
    }
}
