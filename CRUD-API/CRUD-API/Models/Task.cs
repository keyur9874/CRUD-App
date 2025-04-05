namespace CRUD_API.Models
{
    /// <summary>
    /// Represents a task assigned within a project.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Gets or sets the unique identifier of the task.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the task.
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Gets or sets the detailed description of the task.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the task.
        /// </summary>
        public TaskType TaskType { get; set; }

        /// <summary>
        /// Gets or sets the current status of the task.
        /// </summary>
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the estimated number of hours required to complete the task.
        /// </summary>
        public int EstimationHour { get; set; }

        /// <summary>
        /// Gets or sets the actual number of hours spent on the task.
        /// </summary>
        public int ActualHour { get; set; }

        /// <summary>
        /// Gets or sets the project to which this task belongs.
        /// </summary>
        public Project Project { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user to whom the task is assigned. This can be null if not assigned.
        /// </summary>
        public User? User { get; set; }
    }

    /// <summary>
    /// Specifies the type or category of a task.
    /// </summary>
    public enum TaskType
    {
        /// <summary>
        /// New feature development work.
        /// </summary>
        Development = 1,

        /// <summary>
        /// Activities related to deployment, including code review fixes and pull request reviews.
        /// </summary>
        Deployment,

        /// <summary>
        /// Tasks related to identifying and fixing bugs.
        /// </summary>
        BugFixing,

        /// <summary>
        /// Understanding the story or requirements through documentation or discussion.
        /// </summary>
        StoryUnderStanding,

        /// <summary>
        /// Preparing a tentative time or effort estimation for a story or task.
        /// </summary>
        StoryEstimation
    }

    /// <summary>
    /// Specifies the current progress status of a task.
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>
        /// Task is ready to be picked up for development.
        /// </summary>
        ToDo = 1,

        /// <summary>
        /// Task is currently being developed.
        /// </summary>
        InProgress,

        /// <summary>
        /// Task has been submitted for code review.
        /// </summary>
        CodeReview,

        /// <summary>
        /// Task is ready to be tested.
        /// </summary>
        ReadyForTest,

        /// <summary>
        /// Task is currently under testing.
        /// </summary>
        Test,

        /// <summary>
        /// A bug has been found and needs to be fixed.
        /// </summary>
        BugFixing,

        /// <summary>
        /// Task has been completed.
        /// </summary>
        Done
    }
}
