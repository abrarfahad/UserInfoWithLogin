
namespace UserInfoWithLogin.Entities
{
    public class Users:BaseEntity
    {
        public enum UserTypeEnum{
            Admin,
            FreeUser,
            PaidUser
        };
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public int UserType { get; set; }
    }
}
