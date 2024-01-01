using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lighthouse.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Name of the Event: ")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Event Description:")]
        public string Description { get; set; }

        public bool IncludeEmail { get; set; }
        public bool IncludeWebsite { get; set; }
        [DisplayName("Paid Event?")]
        public bool IsPaid { get; set; }
        [DisplayName("Free Event?")]
        public bool IsFree { get; set; }

        // Amount for paid events
        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }

    }
}
