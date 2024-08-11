using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenTrabajo.BD.Data.Entity
{
    public class Orden : Entitybase
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "el nombre del vehiculo es obligatorio")]
        [MaxLength(20, ErrorMessage = "el numero permitido de caracteres {1}")]
        public string Vehiculo { get; set; }

        [Required(ErrorMessage = "la patente es obligatoria")]
        [MaxLength(20, ErrorMessage = "el numero permitido de caracteres {1}")]
        public string Dominio { get; set; }

        [MaxLength(2, ErrorMessage = "el numero permitido de caracteres {1}")]
        public string Nafta { get; set; }
        

        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "el numero de telefono es obligatorio")]
        [MaxLength(20, ErrorMessage = "el numero permitido de caracteres {1}")]
        public string Telefono { get; set; }

      
        [MaxLength(200, ErrorMessage = "el numero permitido de caracteres {1}")]
        public string Detalles { get; set; }

        [MaxLength(2, ErrorMessage = "el numero permitido de caracteres {1}")]
        public string CortaCorriente { get; set; }
        

        public string Falla { get; set; }

        [Range(0, 9999999.99)]
        public decimal Presupuesto { get; set; }
        
        
        public string ConfirmoCliente { get; set; }

        [MaxLength(2000, ErrorMessage = "el numero permitido de caracteres {1}")]
        public string TrabajoRealizado { get; set; }
        
        
        public string AvisoRetirar { get; set; }

        [Range(0, 9999999.99)]
        public decimal Total { get; set; }


    }
}
