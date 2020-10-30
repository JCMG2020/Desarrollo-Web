﻿using DevExpress.Web;
using ProyectoFinal.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
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
            string nombre = e.NewValues["nombre"].ToString();
            string placa = e.NewValues["placa"].ToString();

            
            sercivio_colaborador.insertarColaborador(nombre, apellido, dpi, int.Parse(cargo), fecha_nac, fecha_contratacion, domicilio, telefono, placa, bool.Parse("true"));
        }

        protected void dxGridColaborador_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            ServicioColaborador.ServicioColaboradorClient sercivio_colaborador = new ServicioColaborador.ServicioColaboradorClient();
            string id = e.NewValues["idColaborador"].ToString();
            string nombre = e.NewValues["nombre"].ToString();
            string placa = e.NewValues["placa"].ToString();
            string estado = e.NewValues["estado"].ToString();

            sercivio_colaborador.actualizarColaborador(int.Parse(id), nombre, apellido, dpi, int.Parse(cargo), fecha_nac, fecha_contratacion, domicilio, telefono, placa, bool.Parse(estado));

        }

        protected void dxGridColaborador_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            ServicioColaborador.ServicioColaboradorClient sercivio_colaborador = new ServicioColaborador.ServicioColaboradorClient();

            String id = e.Keys["idColaborador"].ToString();
        }

        protected void dxGridColaborador_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            DataTable dt = new DataTable();   
            dt.Columns.Add("idCargo");
            dt.Columns.Add("cargo");


            ServicioColaborador.ServicioColaboradorClient sercivio_colaborador = new ServicioColaborador.ServicioColaboradorClient();



            DataTable dt2 = new DataTable();
            dt2.Columns.Add("idCargo");
            dt2.Columns.Add("cargo");

            if (e.Column.FieldName == "idCargo")
            {

                ASPxComboBox request = e.Editor as ASPxComboBox;
                request.ValueField = "idCargo";
                request.TextField = "cargo";
                request.ValueType = typeof(System.Int32);

                request.DataSource = sercivio_colaborador.ObtenerCargos();
                request.DataBindItems();


            }
        }
    }
}