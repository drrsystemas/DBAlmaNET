using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class UsuarioWeb
    {
        [Required(ErrorMessage = "Ingrese el Correo Electrónico."),
                    EmailAddress(ErrorMessage = "El correo ingresado no es valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese la clave para el sitio")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "La clave tiene que tener como minimo 6 caracteres")]
        public string Contrasena { get; set; }


        private string _error;

        [NotMapped]
        public string P_Error
        {
            get { return _error; }
            set { _error = value; }
        }

    }
}
