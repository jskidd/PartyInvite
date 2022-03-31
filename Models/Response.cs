using System.ComponentModel.DataAnnotations;

namespace PartyInvite.Models
{
    public class Response
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address"), EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number"), Phone]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether or not you will be attending")]
        public bool? WillAttend { get; set; }
    }
}
