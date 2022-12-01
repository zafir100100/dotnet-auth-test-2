namespace dotnet_auth_test_2.Models
{
    // We are not taking data from data base so we get data from constant
    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                new UserModel(){ Username="a",Password="a",Role="Admin"},
                new UserModel(){ Username="b",Password="b",Role="User"},
            };
    }
}
