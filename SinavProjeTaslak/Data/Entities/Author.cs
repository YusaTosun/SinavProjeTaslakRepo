namespace SinavProjeTaslak.Data.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public ICollection<Blog> Blogs { get; set; }

        public Author()
        {
            Blogs = new List<Blog>();
        }
    }
}
