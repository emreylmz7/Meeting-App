namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() {Id=1, Name ="Edin Dzeko", Email="edindzko@gmail.com",Phone = "55520244",WillAttend = true});
            _users.Add(new UserInfo() {Id=2, Name ="Tadic", Email="tadic@gmail.com",Phone = "55520255",WillAttend = true});
            _users.Add(new UserInfo() {Id=3, Name ="Ryan Kent", Email="rynakent@gmail.com",Phone = "55520288",WillAttend = false});
            _users.Add(new UserInfo() {Id=4, Name ="Szymanski", Email="szymnaski@gmail.com",Phone = "55520277",WillAttend = true});
        }

        public static List<UserInfo> Users 
        {
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

        
    }
}