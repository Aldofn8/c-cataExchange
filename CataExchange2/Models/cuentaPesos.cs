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
    
    public partial class cuentaPesos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cuentaPesos()
        {
            this.Comercia = new HashSet<Comercia>();
            this.enviaDeposita = new HashSet<enviaDeposita>();
            this.estadoCuenta = new HashSet<estadoCuenta>();
            this.operacionesPesos = new HashSet<operacionesPesos>();
        }
    
        public int idCuentaPesos { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public string cbu { get; set; }
        public Nullable<decimal> saldo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comercia> Comercia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enviaDeposita> enviaDeposita { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estadoCuenta> estadoCuenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<operacionesPesos> operacionesPesos { get; set; }
    }
}