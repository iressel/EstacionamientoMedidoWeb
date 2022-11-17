using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstacionamientoMedido.Models
{
    public class Client
    {
        public Guid Id { get; set; }

        [DisplayName("Nombre y Apellido:")]
        [Required(ErrorMessage = "Debe ingresar nombre y apellido del cliente.", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [DisplayName("Dni:")]
        [Required(ErrorMessage = "Debe ingresar dni del cliente.", AllowEmptyStrings = false)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Los valores deben ser sólo numéricos.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Debe Ingresar una cantitad de ocho números.")]
        public string DocumentNumber { get; set; }

        [DisplayName("Correo electrónico:")]
        [RegularExpression("^[a-zA-Z0-9.!#$*+=?^_`{|}~-]+@[a-zA-Z0-9][a-zA-Z0-9-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z]+(\\.[a-zA-Z][a-zA-Z]+)*$", ErrorMessage = "Debe ingresar un formato de email válido.")]
        public string Email { get; set; }
    }
}
