using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Proxy
{
    public class MemberProxy
    {
        private static readonly Dictionary<string, Member> sr_KnownMembers = new Dictionary<string, Member>();
        public Member LinkedMember { private set; get; }
        public MemberProxy(User i_GivenUser)
        {
            if (sr_KnownMembers.ContainsKey(i_GivenUser.Name))
            {
                LinkedMember = sr_KnownMembers[i_GivenUser.Name];
            }

            else
            {
                LinkedMember = new Member(i_GivenUser);
                sr_KnownMembers.Add(i_GivenUser.Name, LinkedMember);
            }
        }
    }
}
