using FacebookWrapper.ObjectModel;
using Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Utility
{
    public class CliqueAnalyzer
    {
        private readonly XElement XmlElement;
        public  CliqueAnalyzer()
        {
            try
            {
                FileInfo fi = new FileInfo(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);
                string filePath = fi.ToString() + @"\XML\CliqueInterests.xml";
                XmlElement = XElement.Load(filePath);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void DetermineCliqueMainInterest(Clique i_CliqueToCheck)
        {
            int mostInterestMemberCount;
            Dictionary<string, int> cliqueResults = new Dictionary<string, int>();

            foreach(var member in i_CliqueToCheck.CliqueMembers)
            {
                if (member.Value.IsAnalyzed == false)
                {
                    member.Value.MostInterest = determineMemberInterest(member.Value.FetchedUser);
                    member.Value.IsAnalyzed = true;
                }
            }
            foreach (var item in Enum.GetNames(typeof(eMostInterest)))
            {
                cliqueResults.Add(item, 0);
            }
            foreach(var member in i_CliqueToCheck.CliqueMembers)
            {
                cliqueResults[member.Value.MostInterest.ToString()]++;
            }

            i_CliqueToCheck.MostInterest = examineInterestResults(cliqueResults, out mostInterestMemberCount);
            i_CliqueToCheck.MostInterestMembersCount = mostInterestMemberCount;
            i_CliqueToCheck.isAnalyzed = true;
            determineCliqueRank(i_CliqueToCheck);

        }

        private void determineCliqueRank(Clique i_CliqueToCheck)
        {
            try
            {
                double ratio = ((double)i_CliqueToCheck.MostInterestMembersCount / (double)i_CliqueToCheck.MembersCount);
                i_CliqueToCheck.Rank = determineRankByGivenRatio(ratio);
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Clique has no members");
            }

        }

        private eMostInterest examineInterestResults(Dictionary<string, int> i_memberResults, out int io_MostInterestMembersCount)
        {
            eMostInterest result = eMostInterest.UnKnown;
            io_MostInterestMembersCount = 0;

            if (i_memberResults.Values.Max() > 0)
            {
                string maxEnumString = i_memberResults.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                io_MostInterestMembersCount = i_memberResults.Values.Max();
                result = determineEnumValueByGivenString(maxEnumString);
            }


            return result;
        }

        private eMostInterest examineInterestResults(Dictionary<string, int> i_memberResults)
        {
            eMostInterest result = eMostInterest.UnKnown;
            if (i_memberResults.Values.Max() > 0)
            {
                string maxEnumString = i_memberResults.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                result = determineEnumValueByGivenString(maxEnumString);
            }

            return result;
        }

        private eCliqueRank determineRankByGivenRatio(double i_Ratio)
        {
            eCliqueRank rank = eCliqueRank.Bad;
            if (i_Ratio < 0.1)
            {
                rank = eCliqueRank.VeryBad;
            }
            else if (i_Ratio >= 0.1 && i_Ratio < 0.2)
            {
                rank = eCliqueRank.Bad;
            }
            else if (i_Ratio >= 0.2 && i_Ratio < 0.3)
            {
                rank = eCliqueRank.Mediocre;
            }
            else if (i_Ratio >= 0.3 && i_Ratio < 0.4)
            {
                rank = eCliqueRank.Good;
            }
            else if (i_Ratio >= 0.4 && i_Ratio < 0.5)
            {
                rank = eCliqueRank.VeryGood;
            }
            else if (i_Ratio >= 0.5)
            {
                rank = eCliqueRank.Excellent;
            }

            return rank;
        }

        private eMostInterest determineMemberInterest(User i_UserToAnalyze)
        {

            Dictionary<string, int> memberResults = new Dictionary<string, int>();

            searchKeywords(memberResults, i_UserToAnalyze);

            return examineInterestResults(memberResults);
        }

        private void searchKeywords(Dictionary<string, int> i_MemberResults, User i_UserToAnalyze)
        {
            foreach (var interest in this.XmlElement.Elements("Interest"))
            {
                string currentInterest = interest.Attribute("Name").Value;
                i_MemberResults.Add(currentInterest, 0);
                foreach (var keyword in interest.Elements("KeyWord"))
                {
                    foreach (Post post in i_UserToAnalyze.Posts)
                    {
                        if (post.Message != null)
                        {
                            if (post.Message.Contains(keyword.Attribute("value").Value))
                            {
                                i_MemberResults[currentInterest]++;
                            }
                        }
                    }

                }
            }
        }

        private eMostInterest determineEnumValueByGivenString(string maxEnumString)
        {
            eMostInterest memberInterest = eMostInterest.UnKnown;
            switch (maxEnumString)
            {
                case "Food":
                    memberInterest = eMostInterest.Food;
                    break;
                case "Hiking":
                    memberInterest = eMostInterest.Hiking;
                    break;
                case "Sports":
                    memberInterest = eMostInterest.Sports;
                    break;
                case "Tech":
                    memberInterest = eMostInterest.Tech;
                    break;
                case "Market":
                    memberInterest = eMostInterest.Market;
                    break;
                case "Journalism":
                    memberInterest = eMostInterest.Journalism;
                    break;
                default:
                    memberInterest = eMostInterest.UnKnown;
                    break;
            }

            return memberInterest;
        }
    }
}
