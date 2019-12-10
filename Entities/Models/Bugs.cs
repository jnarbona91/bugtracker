using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Bugs
    {
        public Guid BugsId { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime DateOfBug { get; set; }

        [Required(ErrorMessage = "Bug details required")]
        public string BugDetails { get; set; }

        [ForeignKey(nameof(Project))]
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
