//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SINU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vPersona_Domicilio
    {
        public string Email { get; set; }
        public int IdPersona { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Unidad { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string CODIGO_POSTAL { get; set; }
        public string Prov_Loc_CP { get; set; }
        public string IdPais { get; set; }
        public Nullable<int> IdLocalidad { get; set; }
        public string EventualCalle { get; set; }
        public string EventualNumero { get; set; }
        public string EventualPiso { get; set; }
        public string EventualUnidad { get; set; }
        public string EventualPais { get; set; }
        public string EventualProvincia { get; set; }
        public string EventualLocalidad { get; set; }
        public string EventualCodigo_Postal { get; set; }
        public string EventualProv_Loc { get; set; }
        public Nullable<int> EventualIdLocalidad { get; set; }
        public string EventualIdPais { get; set; }
        public int IdDomicilioDNI { get; set; }
        public int IdDomicilioActual { get; set; }
    }
}
