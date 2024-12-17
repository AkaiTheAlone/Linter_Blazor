using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Linter.Modelos.Modelos
{
    // Add profile data for application users by adding properties to the ApplicationUser class

    public class TAB001_Usuarios : IdentityUser<int>
    {
        [Required(ErrorMessage = "� necess�rio definir um tipo de usu�rio.")]
        [PersonalData]
        public byte TipoUsuario { get; set; }//talvez isso esteja mais relacionado a tabelas de roles doq a de usuarios, pensar sobre

    }

}
