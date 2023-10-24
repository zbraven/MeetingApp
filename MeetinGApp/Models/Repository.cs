namespace MeetinGApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo()
            {
                Id = 1,
                Name = "Ali Sarıcan",
                Email = "abc@gmail.com",
                Phone = "213123",
                WillAttend = true
            });
            _users.Add(new UserInfo()
            {
                Id = 2,
                Name = "Ayşe Sarıcan",
                Email = "abc@gmail.com",
                Phone = "213123",
                WillAttend = false
            });
            _users.Add(new UserInfo()
            {
                Id = 3,
                Name = "Veli Sarıcan",
                Email = "abc@gmail.com",
                Phone = "213123",
                WillAttend = true
            });
        }
        public static List<UserInfo> Users
        {
            get
            { return _users; }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count+1;  //Kişi sayısı+1 her seferinde gelecek olan elemana ID veriyoruz.
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user=>user.Id==id);
        }
    }
}
