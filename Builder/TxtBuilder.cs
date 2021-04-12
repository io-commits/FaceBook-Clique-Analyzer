using System;
using System.Collections.Generic;
using System.Text;
using Logic;
using System.IO;

namespace Builder
{
    public class TxtBuilder : ICliqueDocBuilder
    {
        public void CreateDoc(ICollection<Clique> i_GivenCliques, string i_FilePath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Clique clique in i_GivenCliques)
            {
                string header = appendCliqueHeader(clique);
                stringBuilder.Append(header);
                stringBuilder.Append(Environment.NewLine);
                appendCliqueMembers(clique, stringBuilder);
            }

            saveFile(i_FilePath, stringBuilder);
        }

        public void CreateDoc(Clique i_GivenClique, string i_FilePath)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string header = appendCliqueHeader(i_GivenClique);
            stringBuilder.Append(header);
            stringBuilder.Append(Environment.NewLine);
            appendCliqueMembers(i_GivenClique, stringBuilder);

            saveFile(i_FilePath, stringBuilder);
        }

        private void appendCliqueMembers(Clique i_GivenClique, StringBuilder stringBuilder)
        {
            foreach (Member member in i_GivenClique.CliqueMembers.Values)
            {
                string memberesString = string.Format(
@"Name - {0}", member.Name
);
                stringBuilder.Append(memberesString);
                stringBuilder.Append(Environment.NewLine);
            }
        }

        private string appendCliqueHeader(Clique clique)
        {
            return string.Format(
@"ID - {0}
Member Count - {1}
Males Count - {2}
Female Count - {3}
Dominant Gender - {4}
Most Interst - {5}
Most interest Member Count - {6}
Rank - {7}
Descruption - {8}",
clique.ID.ToString(),
clique.MembersCount.ToString(),
clique.MalesCount.ToString(),
clique.FemaleCount.ToString(),
clique.DominantGender,
clique.MostInterest.ToString(),
clique.MostInterestMembersCount.ToString(),
clique.Rank.ToString(),
clique.Description);
        }

        private static void saveFile(string i_FilePath, StringBuilder stringBuilder)
        {
            using (StreamWriter streamWriter = new StreamWriter(string.Format(@"{0}/Export.txt", i_FilePath)))
            {
                streamWriter.Write(stringBuilder);
            }
        }
    }
}
