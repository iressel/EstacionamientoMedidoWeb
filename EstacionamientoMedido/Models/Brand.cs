using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstacionamientoMedido.Models
{
    public class Brand
    {
        public Guid Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Debe ingresar un nombre de marca.", AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
