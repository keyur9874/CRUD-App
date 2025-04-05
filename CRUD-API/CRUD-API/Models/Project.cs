namespace CRUD_API.Models
{
    /// <summary>
    /// Represents a project within the system.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Gets or sets the unique identifier of the project.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets an optional description of the project.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the project is currently active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the project is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
