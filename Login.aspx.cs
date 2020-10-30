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
        int MySession = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["User"] = "";
        }
        protected void dxBtnAceptar_Click(object sender, EventArgs e)
        {

            //ServiceUser.ServiciosUsuarioClient ServicioUser = new ServiceUser.ServiciosUsuarioClient();
            ServiceUserLocal.ServiciosUsuarioClient ServicioUserLocal = new ServiceUserLocal.ServiciosUsuarioClient();

            string correo = txtCorreo.Text;
            string contrasena = txtContrasena.Text;
            ///ServicioUser.LoginUsuario(correo, contrasena);

			try
			{
            var MyUSR = ServicioUserLocal.LoginUsuario(correo,contrasena);
                      
			//Session["User"] = MyUSR.usuario_alias
			//Session["UserId"] = MyUSR.idUsuario
			//Session["UserType"] = MyUSR.tipo_usuario
			
			 } catch (Exception ex)
             {
                       // Usuario invalido
             }
			
            valida(correo, contrasena);
        }
        public void valida(String corr, String clave)
        {
            Session.Timeout = 30;
            string user = "";
            int userId = 0;
            int userType = 0;
            MySession = 0;

            switch (corr)
            {
                case "cristian@gmail.com":
                    if (clave == "cristianL") { user = "cristianL"; userId = 2;  userType = 3; MySession = 1; }
                    break;

                case "pedro@hotmail.com":
                    if (clave == "pedroD") { user = "pedroD"; userId = 6; userType = 3; MySession = 1; }
                    break;

                case "karña@gmail.com":
                    if (clave == "usuarioPrueba") { user = "usuarioPrueba"; userId = 7; userType = 3; MySession = 1; }
                    break;

                case "ricardoarmando2010@hotmail.com":
                    if (clave == "12345") { user = "Rick"; userId = 9; userType = 3; MySession = 1; }
                    break;

                case "GMAL":
                    if (clave == "45454") { user = "JOSE_"; userId = 8; userType = 3; MySession = 1; }
                    break;

                case "earcia@gmail.com":
                    if (clave == "1234") { user = "earcia"; userId = 10; userType = 3; MySession = 1; }
                    break;

            }

            if (MySession == 1 )
            {
                string strSessionID;
                strSessionID = HttpContext.Current.Session.SessionID;

                Session["User"] = user;
                Session["UserId"] = userId;
                Session["UserType"] = userType;

                Response.Redirect("~/Index.aspx");
            } else
            {
                lb_error.Text = "Datos de Usuario o Clave incorrectos...";
                txtCorreo.Focus();
            }
   


        }
    }
}