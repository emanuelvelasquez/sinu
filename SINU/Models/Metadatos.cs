﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SINU.Models
{
    public class vPersona_DatosBasicosMetadata
    {
        [ScaffoldColumn(false)]
        public int IdPersona { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<int> IdPostulante { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombres { get; set; }
        [ScaffoldColumn(false)]
        public string Sexo { get; set; }
        [Required]
        //el dni ingresado debe poseer 8 digitos para ser validado
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El DNI ingresado no es valido")]
        //[RegularExpression(@"^([0-9]{2})([.])?([0-9]{3})([.])?([0-9]{3})$", ErrorMessage = "Caracteres ingresados NO validos")]
        //limito al dni que solo acepte numeros
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Caracteres ingresados NO validos")]
        public string DNI { get; set; }
        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }

        [TelefonoCelular("Celular", ErrorMessage = "Este Campo debe esta completado")]
        [DataType(DataType.PhoneNumber)]
        //la expresion regular tiene dos partes, que pueden o no estar separada por un "-", 
        //la primera parte acepta de 2 a 4 numeros  y la segunda de 6 a 8.
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El telefono ingresado, tiene que tener al menos 10 digitos")]
        //[RegularExpression(@"^\(?([0-9]{2,4})\)?[-]?([0-9]{6,8})$", ErrorMessage = "El celular ingresado NO ES VALIDO")]
        [RegularExpression(@"^(\d){10}$", ErrorMessage = "El telefono ingresado NO ES VALIDO")]
        public string Telefono { get; set; }

        [TelefonoCelular("Telefono", ErrorMessage = "este cammpo debe estra completado")]
        [DataType(DataType.PhoneNumber)]
        //la expresion regular tiene dos partes, que pueden o no estar separada por un " - ", 
        //la primera parte acepta de 2 a 4 numeros  y la segunda de 6 a 8.
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El celular ingresado, tiene que tener al menos 10 digitos")]
        [RegularExpression(@"^(\d){10}$", ErrorMessage = "El celular ingresado NO ES VALIDO")]
        public string Celular { get; set; }
        //verificar esto en el caso de ser familiar o postulante si debe ser requiro o no
        //o crear un a validacion perzonalizada donde se requiere en el caso de que se el postulante y en caso de ser un familiar no es requerido
        //[Required]
        //valido los correos ingresados
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$", ErrorMessage = "El correo electronico ingresado no es valido!!!")]
        //ver como modificar el mensaje de error al no ser validado el email
        //[DataType(DataType.EmailAddress,ErrorMessage ="El email ingresado no es valido")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Comentario")]
        [MaxLength(40, ErrorMessage = "Limite de caracteres superado!")]
        public string ComoSeEntero { get; set; }
        [Required]
        [Display(Name = "Como se entero")]
        public Nullable<int> IdComoSeEntero { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<System.DateTime> EmpezoACargarDatos { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<System.DateTime> PidioIngresoAlSist { get; set; }
        [Required]
        [Display(Name = "Instituto a Inscribirse")]
        public Nullable<int> IdPreferencia { get; set; }
        [ScaffoldColumn(false)]
        public string NombreInst { get; set; }
        [ScaffoldColumn(false)]
        public string AspnetUser { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<int> IdSecuencia { get; set; }
        [ScaffoldColumn(false)]
        public string Etapa_Estado { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public int IdSexo { get; set; }
        [Required]
        [Display(Name = "Oficinas y Delegaciones")]
        public Nullable<int> IdDelegacionOficinaIngresoInscribio { get; set; }
        [ScaffoldColumn(false)]
        public string Oficina { get; set; }
        public Nullable<int> Edad { get; set; }
    }

    public class vPersona_DatosPerMetadata
    {
        public string Email { get; set; }
        public int IdPersona { get; set; }
        [Required]
        public string CUIL { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        //[Required]
        [Display(Name = "Edad")]
        public Nullable<int> edad { get; set; }
        [Required]
        [Display(Name = "Estado Civil")]
        public string IdEstadoCivil { get; set; }
        [Display(Name = "Religion")]
        public string IdReligion { get; set; }
        [Display(Name = "Tipo de Nacionalidad")]
        [Required]
        public int idTipoNacionalidad { get; set; }
        public string Nacionalidad { get; set; }
    }

    public class vPersona_AntropometriaMetadata
    {
        public string Email { get; set; }
        public string Genero { get; set; }
        [Required]
        [Display(Name = "Altura(en cm)")]
        public Nullable<int> Altura { get; set; }
        [Required]
        [Display(Name = "Peso(en kg)")]
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        [RegularExpression("([0-9]{1,3})(,[0-9])?", ErrorMessage = "Debe cumplir este formato 999,9")]
        public Nullable<decimal> Peso { get; set; }
        public Nullable<decimal> IMC { get; set; }
        [Required]
        [Display(Name = "1° Perimetro de Cabeza")]
        public Nullable<int> PerimCabeza { get; set; }
        [Display(Name = "2° Perimetro de Torax")]
        [Required]
        public Nullable<int> PerimTorax { get; set; }
        [Display(Name = "3° Perimetro de Cintura")]
        [Required]
        public Nullable<int> PerimCintura { get; set; }
        [Required]
        [Display(Name = "6° Perimetro de Cadera")]
        public Nullable<int> PerimCaderas { get; set; }
        [Required]
        [Display(Name = "4° Largo de Pantalon")]
        public Nullable<int> LargoPantalon { get; set; }
        [Required]
        [Display(Name = "5° Largo de Entrepierna")]
        public Nullable<int> LargoEntrep { get; set; }
        [Display(Name = "2° Largo de Falda")]
        public Nullable<int> LargoFalda { get; set; }
        [Required]
        public Nullable<int> Cuello { get; set; }
        [Required]
        public Nullable<int> Calzado { get; set; }
        [Required]
        public int IdPersona { get; set; }
    }

    public partial class vPersona_DomicilioMetadata
    {
        public string Email { get; set; }
        public int IdPersona { get; set; }
        public string Calle { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "Solo se aceptan caracteres numericos")]
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Unidad { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        [Display(Name = "Codigo Postal")]
        public string CODIGO_POSTAL { get; set; }
        public string Prov_Loc_CP { get; set; }
        [Display(Name = "Pais")]
        public string IdPais { get; set; }
        public Nullable<int> IdLocalidad { get; set; }
        [Display(Name = "Calle")]
        public string EventualCalle { get; set; }
        [Display(Name = "Numero")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Solo se aceptan caracteres numericos")]
        public string EventualNumero { get; set; }
        [Display(Name = "Piso")]
        public string EventualPiso { get; set; }
        [Display(Name = "Unidad")]
        public string EventualUnidad { get; set; }
        [Display(Name = "Pais")]
        public string EventualPais { get; set; }
        [Display(Name = "Provincia")]
        public string EventualProvincia { get; set; }
        [Display(Name = "Localidad")]
        public string EventualLocalidad { get; set; }
        [Display(Name = "Codigo Postal")]
        public string EventualCodigo_Postal { get; set; }
        public string EventualProv_Loc { get; set; }
        public Nullable<int> EventualIdLocalidad { get; set; }
        public string EventualIdPais { get; set; }
        public int IdDomicilioDNI { get; set; }
        public int IdDomicilioActual { get; set; }
    }

    public partial class VPersona_EstudioMetadata
    {
        public int IdPersona { get; set; }
        [Required]
        [Display(Name = "Nivel de Estudio")]
        public Nullable<int> IdNiveldEstudio { get; set; }
        public int IdEstudio { get; set; }
        [Required]
        public string Titulo { get; set; }
        public bool Completo { get; set; }
        public int IdInstitutos { get; set; }
        [Display(Name = "Nombre del Instituto")]
        public string Nombre { get; set; }
        [RegularExpression("^-?[0-9]+([,][0-9]*)?$", ErrorMessage = "Solo se aceptan numeros enteros o decimales")]
        public Nullable<double> Promedio { get; set; }
        [Display(Name = "Cantidad de Materias Adeudadas")]
        public Nullable<int> CantidadMateriaAdeudadas { get; set; }
        [Display(Name = "Ultimo año Cursado")]
        [RegularExpression("^-?[0-9]*", ErrorMessage = "Solo se aceptan numeros enteros")]
        public Nullable<int> ultimoAnioCursado { get; set; }
        public string Nivel { get; set; }
        public string NombreYPaisInstituto { get; set; }
        public string Jurisdiccion { get; set; }
        public string Localidad { get; set; }
    }

    public partial class vPersona_IdiomaMetadadata
    {
        public string Email { get; set; }
        public Nullable<int> IdPersona { get; set; }
        [Required(ErrorMessage = "Debe seleccionar Nivel de Habla.")]
        [Display(Name = "Nivel de Habla")]
        public int Habla { get; set; }
        [Required(ErrorMessage = "Debe seleccionar Nivel de Lectura.")]
        [Display(Name = "Nivel de Lectura")]
        public int Lee { get; set; }
        [Required(ErrorMessage = "Debe seleccionar Nivel de Escritura.")]
        [Display(Name = "Nivel de Escritura")]
        public int Escribe { get; set; }
        public string Idioma { get; set; }
        [Required(ErrorMessage = "Debe seleccionar una Idioma.")]
        [Display(Name = "Idioma")]
        public string CodIdioma { get; set; }
        public string NivelHabla { get; set; }
        public string NivelEscribe { get; set; }
        public string NivelLee { get; set; }
        public int IdPersonaIdioma { get; set; }
    }

    public partial class ActividadMilitarMetadadata
    {

        public Nullable<bool> Ingreso { get; set; }
        [Display(Name = "Fecha de Ingreso")]
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        [Display(Name = "Fecha de Baja")]
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string CausaMotivoNoingreso { get; set; }
        [Display(Name = "Descripcion de la Baja")]
        public string MotivoBaja { get; set; }
        public string Jerarquia { get; set; }
        public string Cargo { get; set; }
        public string Destino { get; set; }
        [Display(Name = "Situacion de Revista")]
        public int IdSituacionRevista { get; set; }
        [Required(ErrorMessage = "Debe Seleccionar un Fuerza")]
        public int IdFuerza { get; set; }
        [Display(Name = "Motivo de Baja")]
        public int IdBaja { get; set; }
        public int IdActividadMilitar { get; set; }
        public virtual Fuerza Fuerza { get; set; }
    }

    public partial class vPersona_ActividadMilitarMetadata
    {
        public int IdPersona { get; set; }
        public int IdActividadMilitar { get; set; }
        public int IdFuerza { get; set; }
        public string Fuerza { get; set; }
        public string Jerarquia { get; set; }
        public string Cargo { get; set; }
        public string Destino { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<bool> Ingreso { get; set; }
    }

    public partial class vPersona_SituacionOcupacionalMetadata
    {
        public int IdPersona { get; set; }
        [Display(Name = "Estado Ocupacional")]
        public int IdEstadoOcupacional { get; set; }
        public int IdSituacionOcupacional { get; set; }
        public string EstadoOcupacional { get; set; }
        public string Descripcion { get; set; }
        [Display(Name = "Ocupacion Actual")]
        public string OcupacionActual { get; set; }
        [Display(Name = "Domiciolio Laboral")]
        public string DomicilioLaboral { get; set; }
        [Display(Name = "Años Trabajados")]
        public Nullable<int> AniosTrabajados { get; set; }
        public string Oficio { get; set; }
        public bool CargaOcupacionActual { get; set; }
        public string Explicacion { get; set; }
        public string DescInteres { get; set; }

    }

    public partial class vEntrevistaLugarFechaMetadata
    {
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")] public Nullable<System.DateTime> FechaEntrevista { get; set; }
        public int IdPersona { get; set; }
        public int IdInscripcion { get; set; }
        public int IdSecuencia { get; set; }
        public string Etapa { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
    }

    public class vUsuariosAdministrativosMetadata
    {
        [Required]
        [Display(Name = "Matricula de Revista")]
        public string mr { get; set; }
        [Required]
        public string Grado { get; set; }
        [Required]
        public string Destino { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public string Comentario { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime FechUltimaAct { get; }

        [Required]
        //[RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$", ErrorMessage = "El correo electronico ingresado no es valido!!!")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Perfil")]
        public string codGrupo { get; set; }

        public int IdOficinasYDelegaciones { get; set; }
    }

    public partial class PeriodosInscripcionesMetadata
    {
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [VPers_ControlRangoPeriodos_("IdInstitucion", ErrorMessage = "La fecha de Inicio ingresada esta dentro de otro periodo")]
        [Display(Name = "Fecha de Inicio")]
        public System.DateTime FechaInicio { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [VPers_ControlRangoPeriodos_("IdInstitucion", ErrorMessage = "La fecha Final ingresada esta dentro de otro periodo")]
        [VPers_FIMenorFF_("FechaInicio", ErrorMessage = "Fecha Final debe ser superior a fecha de Inicio del rango.")]
        [Display(Name = "Fecha Final")]
        public System.DateTime FechaFinal { get; set; }
        [Required]
        [Display(Name = "Institución")]
        public int IdInstitucion { get; set; }
        [Display(Name = "Período de Inscripción")]
        public int IdPeriodoInscripcion { get; set; }

    }

    public partial class vPersona_FamiliarMetadata
    {
        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }

        [Display(Name = "Fecha de Casamiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FechaCasamiento { get; set; }


        [Required]
        [Display(Name = "Parentesco")]
        public Nullable<int> idParentesco { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public Nullable<int> IdSexo { get; set; }
        [Required]
        [Display(Name = "Estado Civil")]
        public string IdEstadoCivil { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        //el dni ingresado debe poseer 8 digitos para ser validado
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El DNI ingresado no es valido")]
        //[RegularExpression(@"^([0-9]{2})([.])?([0-9]{3})([.])?([0-9]{3})$", ErrorMessage = "Caracteres ingresados NO validos")]
        //limito al dni que solo acepte numeros
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Caracteres ingresados NO validos")]
        public string DNI { get; set; }
        [Required]
        public Nullable<bool> Vive { get; set; }
        [Required]
        [Display(Name = "Convive")]
        public Nullable<bool> ConVive { get; set; }
        // [Required]
        [Display(Name = "Religion")]
        public string IdReligion { get; set; }
        [Required]
        [Display(Name = "Tipo Nacionalidad")]
        public Nullable<int> idTipoNacionalidad { get; set; }
        [Required]
        public string CUIL { get; set; }
    }
    public partial class vInscripcionEtapaEstadoUltimoEstadoMetadata
    {
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Fecha { get; set; }
    }

    public partial class SexoMetadata
    {
        [Required]
        public string Descripcion { get; set; }
    }
    public partial class FuerzaMetadata
    { 
        [Required]
        [Display(Name = "Fuerza")]
        public string Fuerza1 { get; set; }
    }

    public partial class TipoNacionalidadMetadata
    {
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Tipo { get; set; }
    }
    public partial class vConvocatoriaDetallesMetadata
    {
        [Display(Name = "Inicio")]
        public System.DateTime FechaInicio { get; set; }
        [Display(Name = "Finalización")]
        public System.DateTime FechaFinal { get; set; }
        [Display(Name = "Modalidad")]
        public string Modalidad { get; set; }
        [Display(Name = "Grupo")]
        public string Desc_Grupo { get; set; }
        [Display(Name = "Instituto")]
        public string NombreInst { get; set; }
        [Display(Name = "Código Modalidad")]
        public string IdModalidad { get; set; }
        [Display(Name = "Código Grupo")]
        public string IdGrupoCarrOficio { get; set; }
    }
    public partial class InstitucionMetadata
    {
        [Display(Name = "Instituto")]
        public string NombreInst { get; set; }
    }

    //public partial class GrupoCarrOficioMetadata
    //{
    //    [Display(Name = "Código Grupo")]
    //    public string IdGrupoCarrOficio { get; set; }
    //}
    //public partial class ModalidadMetadata
    //{
    //    [Display(Name = "Código Modalidad")]
    //    public string IdModalidad { get; set; }
    //}
}