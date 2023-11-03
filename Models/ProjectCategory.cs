using System.Text.Json.Serialization;
using System.Threading;

namespace ProjectManagement.Models
{
    public class ProjectCategory
    {
        public Guid ProjectCategoryId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<Project> Project { get; set; }

    }
}
