//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CataExchange2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OperaCripto
    {
        public int idOperaCripto { get; set; }
        public Nullable<int> idBilletera { get; set; }
        public Nullable<int> idCriptoMoneda { get; set; }
        public Nullable<double> cantidadCripto { get; set; }
        public string tipoOperacion { get; set; }
        public Nullable<System.DateTime> fechaHora { get; set; }
        public Nullable<decimal> importe { get; set; }
    
        public virtual Billetera Billetera { get; set; }
        public virtual criptoMonedas criptoMonedas { get; set; }
    }
}
