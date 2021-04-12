using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facade
{

    public class FacadeHomePage
    {
        public User LoggedInUser { get; private set; }
        private LoginResult m_LoginResult;
        public void LoginWithToken(string i_GivenToken)
        {
            m_LoginResult = FacebookService.Connect(i_GivenToken);
            LoggedInUser = m_LoginResult.LoggedInUser;
        }

        public void LoginWithCredentials()
        {
            m_LoginResult = FacebookService.Login("430232305043727",
                      "ads_management",
                      "ads_read",
                      "attribution_read",
                      "catalog_management",
                      "business_management",
                      "email",
                      "groups_access_member_info",
                      "instagram_basic",
                      "instagram_manage_comments",
                      "instagram_manage_insights",
                      "leads_retrieval",
                      "manage_pages",
                      "pages_manage_ads",
                      "pages_manage_cta",
                      "pages_manage_engagement",
                      "pages_manage_instant_articles",
                      "pages_manage_metadata",
                      "pages_manage_posts",
                      "pages_messaging",
                      "pages_read_engagement",
                      "pages_read_user_content",
                      "pages_show_list",
                      "pages_user_gender",
                      "pages_user_locale",
                      "pages_user_timezone",
                      "publish_pages",
                      "publish_to_groups",
                      "publish_video",
                      "read_insights",
                      "user_age_range",
                      "user_birthday",
                      "user_friends",
                      "user_gender",
                      "user_hometown",
                      "user_likes",
                      "user_link",
                      "user_location",
                      "user_photos",
                      "user_posts",
                      "user_videos",
                      "whatsapp_business_management"
                       );
            LoggedInUser = m_LoginResult.LoggedInUser;

        }

        public string GetProfilePictureUrl()
        {
            return LoggedInUser.PictureNormalURL;
        }

        public List<string> GetUserPosts()
        {
            List<String> userPostsList = new List<string>();

            foreach (var post in LoggedInUser.Posts)
            {
                userPostsList.Add(string.Format("{0} **Post creation time: {1}**", post.Message, post.CreatedTime.ToString()));
            }


            return userPostsList;
        }

        public List<string> GetUserPages()
        {
            List<String> userPagesList = new List<string>();

            foreach (var page in LoggedInUser.LikedPages)
            {
                userPagesList.Add(page.Name);
            }


            return userPagesList;
        }

        public List<string> GetUserGroups()
        {
            List<String> userGrupsList = new List<string>();

            foreach (var group in LoggedInUser.Groups)
            {
                userGrupsList.Add(group.Name);
            }


            return userGrupsList;
        }

        public List<string> GetUserFriends()
        {
            List<String> userFriendList = new List<string>();

            foreach (var friend in LoggedInUser.Friends)
            {
                userFriendList.Add(friend.Name);
            }

            return userFriendList;
        }

        public string GetGroupPictureUrl(string selectedItem)
        {
            return LoggedInUser.Groups.Find(x => x.Name == selectedItem).PictureNormalURL;
        }

        public string GetPagePictureUrl(string selectedItem)
        {
            return LoggedInUser.LikedPages.Find(x => x.Name == selectedItem).PictureNormalURL;
        }

        public string GetUserName()
        {
            return LoggedInUser.Name;
        }

        public List<string> GetFriendFriendListByGivingHisName(string i_GivenUserString)
        {
            List<String> friendListString = new List<string>();
            FacebookObjectCollection<User> friendLists = LoggedInUser.Friends.Find(x => x.Name == i_GivenUserString).Friends;

            if (friendLists.Count > 0)
            {
                foreach (var friend in friendLists)
                {
                    friendListString.Add(friend.Name);
                }
            }

            return friendListString;
        }

        public string GetFriendImageUrlByGivingHisName(string i_FriendName)
        {
            string friendImageUrl = LoggedInUser.Friends.Find(x => x.Name == i_FriendName).PictureNormalURL;

            return friendImageUrl;
        }
    }
}
