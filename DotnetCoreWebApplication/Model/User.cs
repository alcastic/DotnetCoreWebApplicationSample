namespace DotnetCoreWebApplication.Model
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }

        public User(int id, string nickName,string name)
        {
            Id = id;
            NickName = nickName;
            Name = name;
        }
    }
}