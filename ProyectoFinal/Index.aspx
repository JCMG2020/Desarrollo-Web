<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProyectoFinal.Index2" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" style="width: 100%">
        <div class="col-md-12 col-sm-12">
            <div class="x_panel col-md-12 col-sm-12">
                <div class="x_title">
                    <h2>Pedidos <small></small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                        <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                <a class="dropdown-item" href="#">Settings 1</a>
                                <a class="dropdown-item" href="#">Settings 2</a>
                            </div>
                        </li>
                        <li><a class="close-link"><i class="fa fa-close"></i></a>
                        </li>
                    </ul>
                    <div class="clearfix"></div>

                </div>
                <div class="x_content " style=" width: 100%">

                    
                    <div class="row"  >
                        
                    <dx:ASPxGridView ID="dxGridProducto1" runat="server" Theme="Material" Width="100%" AutoGenerateColumns="false" >
                        <SettingsPager PageSize="10" />
                        <SettingsSearchPanel Visible="true" />
                        <Settings ShowFooter="True" />
                        <SettingsCommandButton>
                            <EditButton Text="Modificar" />
                            <NewButton Text="Nuevo" />
                            <DeleteButton Text="Eliminar" />
                        </SettingsCommandButton>
                        <Columns >
                            <dx:GridViewCommandColumn ShowEditButton="true" ShowNewButton="true" ShowDeleteButton="true" />

                            <dx:GridViewDataTextColumn Caption="NUMERO DE CUENTA" FieldName="NUMERO_CUENTA" VisibleIndex="1" ReadOnly="true">
                            </dx:GridViewDataTextColumn>

                            <dx:GridViewDataTextColumn Caption="SALDO DISPONIBLE" FieldName="SALDO" VisibleIndex="3" ReadOnly="true">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <SettingsPager>
                            <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
                        </SettingsPager>
                    </dx:ASPxGridView>

                    </div>
                    <div class="ln_solid">
                        <div class="form-group">
                            <div class="col-md-6 offset-md-3">
                                <button type='submit' class="btn btn-primary">Submit</button>
                                <button type='reset' class="btn btn-success">Reset</button>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
</asp:Content>