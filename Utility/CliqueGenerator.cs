using FacebookWrapper.ObjectModel;
using Logic;
using Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class CliqueGenerator 
    {
        public Dictionary<int, Clique> BuildCliques(User i_LoggedInUser)
        {
            Dictionary<int, Clique> returnedDictionary = new Dictionary<int, Clique>();
            int counter = 0;

            foreach (var friend in i_LoggedInUser.Friends)
            {
                Clique currentClique = new Clique(counter);
                currentClique.AddMember(new MemberProxy(friend).LinkedMember);
                foreach (var friendOfFriend in friend.Friends)
                {
                    currentClique.AddMember(new MemberProxy(friendOfFriend).LinkedMember);
                }
                if (isCliqueUnique(currentClique, returnedDictionary) == true)
                {
                    returnedDictionary.Add(counter, currentClique);
                    counter++;
                }
            }

            return returnedDictionary;
        }

        private bool isCliqueUnique(Clique i_CurrentClique, Dictionary<int, Clique> i_CliquesDictionary)
        {
            bool returnedVal = true;
            foreach (var clique in i_CliquesDictionary.Values)
            {
                if (clique == i_CurrentClique)
                {
                    returnedVal = false;
                    break;
                }
            }
            return returnedVal;
        }
    }
}
