using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void dxBtnAceptar_Click(object sender, EventArgs e)
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            string correo = txtCorreo.Text;
            string contrasena = txtContrasena.Text;
            sercivio_usuario.LoginUsuario(correo,contrasena);
            
            

        }
    }
}