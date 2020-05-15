namespace DotnetCoreWebApplication.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public Comment(int id, string body)
        {
            Id = id;
            Body = body;
        }
    }
}