namespace SinavProjeTaslak.Data.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogContent { get; set; }
        public string BlogHeader { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
