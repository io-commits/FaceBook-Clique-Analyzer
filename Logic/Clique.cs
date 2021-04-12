using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public class Clique
    {
        public Dictionary<string, Member> CliqueMembers { private set; get; }
        public int ID { private set; get; }
        public int MembersCount { private set; get; }
        public int MalesCount { private set; get; }
        public int FemaleCount { private set; get; }
        public eMostInterest MostInterest { set; get; }
        public string DominantGender { private set; get; }
        public int MostInterestMembersCount { set; get; }
        public bool isAnalyzed { set; get; }
        public eCliqueRank Rank { set; get; }

        public string Description { set; get; }

        public Clique(int i_ID)
        {
            ID = i_ID;
            CliqueMembers = new Dictionary<string, Member>();
            this.MostInterest = eMostInterest.NotChecked;
            this.Rank = eCliqueRank.NotChecked;
            this.Description = "Not described";
        }

        public void AddMember(Member i_MemberToAdd)
        {
            if (!CliqueMembers.ContainsKey(i_MemberToAdd.FetchedUser.Name))
            {
                CliqueMembers.Add(i_MemberToAdd.FetchedUser.Name, i_MemberToAdd);
                MembersCount++;
                determineGender(i_MemberToAdd);
                DominantGender = MalesCount > FemaleCount ? "Males" : "Females";
            }
        }
      
        public void AddMemberNoFieldUpdate(Member i_MemberToAdd)
        {
            CliqueMembers.Add(i_MemberToAdd.FetchedUser.Name, i_MemberToAdd);
        }

        public static bool operator ==(Clique i_FirstClique, Clique i_SecondClique)
        {
            int counter = 0;
            bool returnedValue = true;
            if (i_FirstClique.MembersCount != i_SecondClique.MembersCount)
            {
                returnedValue = false;
            }
            else
            {
                foreach (Member member in i_FirstClique.CliqueMembers.Values)
                {
                    foreach (Member secondMember in i_SecondClique.CliqueMembers.Values)
                    {
                        if (member.FetchedUser.Name == secondMember.FetchedUser.Name)
                        {
                            counter++;
                            break;
                        }
                    }
                }
                if (counter != i_FirstClique.MembersCount || counter != i_SecondClique.MembersCount)
                {
                    returnedValue = false;
                }
            }


            return returnedValue;
        }

        public static bool operator !=(Clique i_FirstClique, Clique i_SecondClique)
        {
            return i_FirstClique == i_SecondClique ? true : false;
        }

        public override bool Equals(object obj)
        {
            return this == ((Clique)obj);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        private void determineGender(Member i_MemberToAdd)
        {
            if (i_MemberToAdd.FetchedUser.Gender == FacebookWrapper.ObjectModel.User.eGender.male)
            {
                MalesCount++;
            }
            else
            {
                FemaleCount++;
            }
        }

        public IEnumerator<Member> GetEnumerator()
        {
            foreach (var member in CliqueMembers)
            {
                if (member.Value.FetchedUser.Gender == FacebookWrapper.ObjectModel.User.eGender.female)
                {
                    yield return member.Value;
                }
            }
        }

        public Clique ShallowCopy()
        {
            Clique clone = (Clique)this.MemberwiseClone();
            clone.CliqueMembers = new Dictionary<string, Member>();

            return clone;
        }

    }
}


