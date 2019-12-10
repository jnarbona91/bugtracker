using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("project")]
    public class Project
    {
        public Guid ProjectId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime DateStarted { get; set; }

        [Required(ErrorMessage = "Project details required")]
        public string ProjectDetails { get; set; }

        public ICollection<Bugs> Bugs { get; set; }
    }
}
