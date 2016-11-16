using System.ComponentModel.DataAnnotations;

namespace Buceo.Web.Models
{
    public class MensajeEmailModel
    {
        [Required(ErrorMessage = "Ingrese su nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese su email.")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido.")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Ingrese su mensaje.")]
        public string Mensaje { get; set; }
    }
}