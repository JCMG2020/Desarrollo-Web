using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] != null)
            {
                txtUsr.Text = Session["User"].ToString();
                txtUsr1.Text = Session["User"].ToString();
            } else {
                Response.Redirect("~/Login.aspx");
            }
         
        }
        public void SessionExit()
        {
            Session["User"] = "";
            Session.Abandon();
        }
    }
}