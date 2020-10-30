﻿using System;
using ProyectoFinal.App_Code.Utilidades;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

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
            string usuario = e.NewValues["usuario_alias"].ToString();
            sercivio_usuario.insertarUsuario(usuario, nombre, apellido, email, contrasena, telefono, int.Parse(tipo_usuario), dpi, bool.Parse("true"));


        }

        protected void dxGridUsuario_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            string id = e.NewValues["idUsuario"].ToString();
            string usuario = e.NewValues["usuario_alias"].ToString();
            sercivio_usuario.actualizarUsuario(int.Parse(id), usuario, nombre, apellido, email, contrasena, telefono, int.Parse(tipo_usuario), dpi, bool.Parse(estado));
        }

        protected void dxGridUsuario_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            string id = e.Keys["idUsuario"].ToString();


        }

        protected void dxGridUsuario_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            ServicioUsuario.ServiciosUsuarioClient sercivio_usuario = new ServicioUsuario.ServiciosUsuarioClient();
            if (e.Column.FieldName == "tipo_usuario")
            {

                ASPxComboBox request = e.Editor as ASPxComboBox;
                request.ValueField = "tipo_usuario";
                request.TextField = "tipo_usuario_nombre";
                request.ValueType = typeof(System.Int32);

                request.DataSource = sercivio_usuario.ObtenerTipoUsuario();
                request.DataBindItems();


            }
        }
    }
}