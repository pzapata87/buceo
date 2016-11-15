using System.ComponentModel.DataAnnotations;

namespace Buceo.Web.Models
{
    public class MensajeEmailModel
    {
        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Email es obligatorio")]
        [EmailAddress(ErrorMessage = "No es un correo válido")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Mensaje es obligatorio")]
        public string Mensaje { get; set; }
    }
}