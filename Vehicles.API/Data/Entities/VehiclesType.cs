using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class VehicleType  //Esta es la entidad
    {
        public int ID { get; set; } // El Id es el numero autoinrementable

        [Display(Name = "Tipo de vehiculo")]   //Lo que visualiza el usuario
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")] //Controlo la cantidad de caracteres. El 1 muestra la cantidad de caracteres permitido (50)
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Significa que el string es un campo obligatorio. En el mensaje el 0 muestra la descripcion tipo de vehiculo
        public string Description { get; set; }
    }
}
