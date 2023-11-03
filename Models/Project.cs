using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagement.Models
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }

        [ForeignKey("ProjectCategoryId")]
        public Guid ProjectCategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual ProjectCategory Category { get; set; }

    }

    public enum Status
    {
        ToDo,
        InProgress,
        Qa,
        Done
    }
}
