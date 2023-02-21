using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FisherMidtermB.Models
{
    public class Taco
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please choose the size of taco")]
        public string Size { get; set; }
        [Required(ErrorMessage = "Please choose the filling for your taco")]
        public string Filling { get; set; }
        [Required(ErrorMessage = "Please provide your first name")]
        
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please provide your last name")]

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please provide your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please provide your the date of your order.")]
        [DisplayName("Date Requested")]
        public DateTime DateRequested { get; set; }
        public double Total { get; set; }

    }
}
