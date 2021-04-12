using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Logic
{
    public class Member
    {
        public User FetchedUser { private set; get; }
        public eMostInterest MostInterest { set; get; }
        public bool IsAnalyzed { set; get; }
        public string Name { private set; get; }
        public Member(User i_User)
        {
            try
            {
                setUser(i_User);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error initializing Member", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            MostInterest = eMostInterest.NotChecked;
        }
        private void setUser(User i_InputUser)
        {
            try
            {
                FetchedUser = i_InputUser;
                Name = FetchedUser.Name;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
