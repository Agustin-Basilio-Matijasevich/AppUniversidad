//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUniversidad.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Profesor_Alumno
    {
        public int ID { get; set; }
        public Nullable<int> id_Alumno { get; set; }
        public Nullable<int> id_Profesor { get; set; }
    
        public virtual Table_Alumno_DB Table_Alumno_DB { get; set; }
        public virtual Table_Profesor_DB Table_Profesor_DB { get; set; }
    }
}