//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpleadoEDM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado_Detalles
    {
        public int Detalles_ID { get; set; }
        public Nullable<int> Empleado_ID { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> ANTIGUEDAD_Pluses { get; set; }
        public Nullable<int> Experiencia_Anios { get; set; }
        public Nullable<int> Salario { get; set; }
        public string Subcategoria { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
