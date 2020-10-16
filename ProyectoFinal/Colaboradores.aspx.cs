using ProyectoFinal.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Colaboradores : System.Web.UI.Page
    {
        ClsErrorHandler log = new ClsErrorHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)

                    cargaColaborador();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }
        }
        public void cargaColaborador()
        {
            ServicioColaborador.ServicioColaboradorClient sercivio_colaborador = new ServicioColaborador.ServicioColaboradorClient();
            dxGridColaborador.DataSource = sercivio_colaborador.ObtenerColaboradorres();
            dxGridColaborador.DataBind();

        }

        protected void dxGridColaborador_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ServicioColaborador.ServicioColaboradorClient sercivio_colaborador = new ServicioColaborador.ServicioColaboradorClient();
            string nombre = e.NewValues["nombre"].ToString();            string apellido = e.NewValues["apellido"].ToString();            string dpi = e.NewValues["DPI"].ToString();            string cargo = e.NewValues["cargo"].ToString();            string fecha_nac = e.NewValues["fechaNacimiento"].ToString();            string fecha_contratacion = e.NewValues["fechaContratacion"].ToString();            string domicilio = e.NewValues["domicilio"].ToString();            string telefono = e.NewValues["telefono"].ToString();
            string placa = e.NewValues["placa"].ToString();

            
            sercivio_colaborador.insertarColaborador(nombre, apellido, dpi, int.Parse(cargo), fecha_nac, fecha_contratacion, domicilio, telefono, placa, bool.Parse("true"));            cargaColaborador();            e.Cancel = true;
        }

        protected void dxGridColaborador_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            ServicioColaborador.ServicioColaboradorClient sercivio_colaborador = new ServicioColaborador.ServicioColaboradorClient();
            string id = e.NewValues["idColaborador"].ToString();
            string nombre = e.NewValues["nombre"].ToString();            string apellido = e.NewValues["apellido"].ToString();            string dpi = e.NewValues["DPI"].ToString();            string cargo = e.NewValues["cargo"].ToString();            string fecha_nac = e.NewValues["fechaNacimiento"].ToString();            string fecha_contratacion = e.NewValues["fechaContratacion"].ToString();            string domicilio = e.NewValues["domicilio"].ToString();            string telefono = e.NewValues["telefono"].ToString();
            string placa = e.NewValues["placa"].ToString();
            string estado = e.NewValues["estado"].ToString();

            sercivio_colaborador.actualizarColaborador(int.Parse(id), nombre, apellido, dpi, int.Parse(cargo), fecha_nac, fecha_contratacion, domicilio, telefono, placa, bool.Parse(estado));            cargaColaborador();            e.Cancel = true;

        }

        protected void dxGridColaborador_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            ServicioColaborador.ServicioColaboradorClient sercivio_colaborador = new ServicioColaborador.ServicioColaboradorClient();

            String id = e.Keys["idColaborador"].ToString();            sercivio_colaborador.eliminarColaborador(int.Parse(id));            cargaColaborador();            e.Cancel = true;
        }
    }
}