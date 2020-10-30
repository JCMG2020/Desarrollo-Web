using System;
using ProyectoFinal.App_Code.Utilidades;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Pedidos : System.Web.UI.Page
    {
        ClsErrorHandler log = new ClsErrorHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)

                    CargaPedido();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }

        }
        void CargaPedido()
        {
            ServicioPedidos.ServicioPedidosClient sercivio_perdidos = new ServicioPedidos.ServicioPedidosClient();
            dxGridPedido.DataSource = sercivio_perdidos.ObtenerPedidos();
            dxGridPedido.DataBind();
        }
    }
}
