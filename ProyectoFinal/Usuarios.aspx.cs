using System;
using ProyectoFinal.App_Code.Utilidades;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Usuarios : System.Web.UI.Page
    {
        ClsErrorHandler log = new ClsErrorHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)

                    CargaUsuario();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }


}
void CargaUsuario()
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            dxGridUsuario.DataSource = sercivio_usuario.ObtenerUsuarios();
            dxGridUsuario.DataBind();
        }
    }
}