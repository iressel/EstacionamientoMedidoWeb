using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstacionamientoMedido.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }//int, decimal, string, Guid, DateTime, TimeSpan, NULL

        [DisplayName("Dni:")]
        [Required(ErrorMessage = "Debe ingresar dni del cliente.", AllowEmptyStrings = false)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Los valores deben ser sólo numéricos.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Debe Ingresar una cantitad de ocho números.")]
        public string ClientDocumentNumber { get; set; }

        [DisplayName("Nombre y Apellido:")]
        [Required(ErrorMessage = "Debe ingresar nombre y apellido del cliente.", AllowEmptyStrings = false)]
        public string ClientName { get; set; }

        [DisplayName("Patente:")]
        [Required(ErrorMessage = "Debe ingresar patente del vehículo.", AllowEmptyStrings = false)]
        public string Patent { get; set; }

        [DisplayName("Modelo vehículo:")]
        public string VehicleModel { get; set; }

        [DisplayName("Marca vehículo:")]
        [Required(ErrorMessage = "Debe seleccionar marca del vehículo.", AllowEmptyStrings = false)]
        public string BrandId { get; set; }

        [DisplayName("Hora entrada:")]
        [DataType(DataType.Time)]
        public TimeSpan CheckIn { get; set; }

        [DisplayName("Hora salida:")]
        [DataType(DataType.Time)]
        public TimeSpan CheckOut { get; set; }

        [DisplayName("Fecha:")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } //DateTime?

        [DisplayName("Calle:")]
        public string Street { get; set; }

        [DisplayName("Altura:")]
        public string StreetHeight { get; set; }//altura

        [DisplayName("Correo electrónico:")]
        public string ClientEmail { get; set; }

        [NotMapped]
        [DisplayName("Marca vehículo:")]
        public string BrandName { get; set; }
        /*     
        ejemplo
        de
        comentario
        largo       
         */
    }
}
