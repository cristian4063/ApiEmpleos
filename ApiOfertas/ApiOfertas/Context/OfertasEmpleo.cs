//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiOfertas.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class OfertasEmpleo
    {
        public long Id { get; set; }
        public string Empleador { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string TiempoExperiencia { get; set; }
        public int CantidadVacantes { get; set; }
        public string Cargo { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public string NivelEstudios { get; set; }
        public string Profesion { get; set; }
        public string Salario { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Sector { get; set; }
        public Nullable<double> Latitud { get; set; }
        public Nullable<double> Longitud { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
        public Nullable<int> NumeroNegativos { get; set; }
    }
}
