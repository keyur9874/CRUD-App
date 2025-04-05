namespace CRUD_API.Models
{
    /// <summary>
    /// Represents a comment made by a user on a task.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Gets or sets the unique identifier for the comment.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the text content of the comment.
        /// </summary>
        public required string CommentText { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the comment was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the user who created the comment.
        /// </summary>
        public User CreatedBy { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date and time when the comment was last updated.
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the task to which this comment belongs.
        /// </summary>
        public Task Task { get; set; } = null!;
    }
}
