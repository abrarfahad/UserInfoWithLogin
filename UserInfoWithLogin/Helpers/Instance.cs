using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfoWithLogin.Helpers
{
    public static class Instance
    {

        public static Entities.Users LoggedInUser { get; set; }
        public static string UserType {
            get {
                int userType = LoggedInUser.UserType;
                Entities.Users.UserTypeEnum userTypeEnum = (Entities.Users.UserTypeEnum)userType;
                string userTypeName = userTypeEnum.ToString();
                return userTypeName;
            }
        }
    }
}
