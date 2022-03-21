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
    using System.Linq;

    public partial class operacionesPesos
    {
        public int idOperacionesP { get; set; }
        public Nullable<int> idCuentaPesos { get; set; }
        public string tipoOperacion { get; set; }
        public decimal importe { get; set; }
    
        public virtual cuentaPesos cuentaPesos { get; set; }

        public List<string> ListarOperacionesPesos()
        {
            var listaOperacionesPesos = new List<operacionesPesos>
            {
                new operacionesPesos {idOperacionesP = 1, idCuentaPesos = 1, tipoOperacion = "envia", importe = 1}
            };
            var listaOP = listaOperacionesPesos.Select(x => x.tipoOperacion).ToList();

            return listaOP;
        }

    }
}
