using System.ComponentModel.DataAnnotations;

namespace MeetinGApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı zorunlu.")]
        public string? Name { get; set; } //null

        [Required(ErrorMessage = "Telefon alanı zorunlu.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "E-mail alanı zorunlu.")]
        [EmailAddress(ErrorMessage ="Hatalı e-mail.")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Katılım durumunu belirtiniz.")]
        public bool? WillAttend { get; set; } //true,false,null
       
    }
}
