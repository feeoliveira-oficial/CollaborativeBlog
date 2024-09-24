namespace CollaborativeBlog.Models
{
    public class BlogPost
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public  User User { get; set; }
        public  string Title { get; set; }
        public  string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public  ICollection<Comment> Comments { get; set; }
    }
}
