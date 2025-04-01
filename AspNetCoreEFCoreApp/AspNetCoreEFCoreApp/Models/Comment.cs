namespace AspNetCoreEFCoreApp.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public int PostId { get; set; }
    }
}
