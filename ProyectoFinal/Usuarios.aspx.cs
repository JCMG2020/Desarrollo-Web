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

        protected void dxGridUsuario_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            string usuario = e.NewValues["usuario_alias"].ToString();            string tipo_usuario = e.NewValues["tipo_usuario_nombre"].ToString();            string nombre = e.NewValues["nombre"].ToString();            string apellido = e.NewValues["apellido"].ToString();            string email = e.NewValues["email"].ToString();            string contrasena = e.NewValues["contrasena"].ToString();            string dpi = e.NewValues["DPI"].ToString();            string telefono = e.NewValues["telefono"].ToString();
            sercivio_usuario.insertarUsuario(usuario, nombre, apellido, email, contrasena, telefono, int.Parse(tipo_usuario), dpi, bool.Parse("true"));            CargaUsuario();            e.Cancel = true;


        }

        protected void dxGridUsuario_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            string id = e.NewValues["idUsuario"].ToString();
            string usuario = e.NewValues["usuario_alias"].ToString();            string tipo_usuario = e.NewValues["tipo_usuario_nombre"].ToString();            string nombre = e.NewValues["nombre"].ToString();            string apellido = e.NewValues["apellido"].ToString();            string email = e.NewValues["email"].ToString();            string contrasena = e.NewValues["contrasena"].ToString();            string dpi = e.NewValues["DPI"].ToString();            string telefono = e.NewValues["telefono"].ToString();            string estado = e.NewValues["estado"].ToString();
            sercivio_usuario.actualizarUsuario(int.Parse(id), usuario, nombre, apellido, email, contrasena, telefono, int.Parse(tipo_usuario), dpi, bool.Parse(estado));            CargaUsuario();            e.Cancel = true;
        }

        protected void dxGridUsuario_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            string id = e.Keys["idUsuario"].ToString();            sercivio_usuario.eliminarUsuario(int.Parse(id));            CargaUsuario();            e.Cancel = true;


        }
    }
}