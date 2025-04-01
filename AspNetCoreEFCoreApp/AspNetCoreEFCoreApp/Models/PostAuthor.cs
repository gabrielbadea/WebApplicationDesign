namespace AspNetCoreEFCoreApp.Models
{
    public class PostAuthor
    {
        public int PostAuthorId { get; set; }

        public int PostId { get; set; }

        public int AuthorId { get; set; }
    }
}
