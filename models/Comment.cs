namespace CollaborativeBlog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public BlogPost Post { get; set; }
        public int UserId { get; set; }
        public  User User { get; set; }
        public  string CommentText { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
