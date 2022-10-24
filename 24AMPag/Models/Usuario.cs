using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _24AMPag.Models
{
    public class Usuario
    {
        [Key]

        public int PkUsuario { get; set; }
        public string Nombrer { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        [ForeignKey("Rol")]

        public int?  FkRol { get; set; }
        
        public Roles Rol { get; set; }

    }
}
