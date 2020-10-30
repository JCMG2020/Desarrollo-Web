<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="ProyectoFinal.Pedidos" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row col-md-12 col-sm-12 ">
        <div class="col-md-12 col-sm-12 ">
            <div class="x_panel col-md-12 col-sm-12 col-xs-12">
                <div class="x_title col-md-12 col-sm-12 ">
                    <h2>Form Design <small>different form elements</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                        <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a class="dropdown-item" href="#">Settings 1</a>
                                </li>
                                <li><a class="dropdown-item" href="#">Settings 2</a>
                                </li>
                            </ul>
                        </li>
                        <li><a class="close-link"><i class="fa fa-close"></i></a>
                        </li>
                    </ul>
                    <div class="clearfix"></div>
                </div>
                <div class="x_content col-md-12 col-sm-12 ">
                    <br>
                    <form runat="server">
                        <div class="contenedor" id="contenedor">
                            <dx:ASPxGridView ID="dxGridPedido" runat="server" AutoGenerateColumns="false"  KeyFieldName="idPedido"  Width="100%" Theme="Material">
                                <SettingsEditing Mode="EditForm"></SettingsEditing>
                                <SettingsPager NumericButtonCount="10" PageSize="10"></SettingsPager>
                                <SettingsPager>
                                    <PageSizeItemSettings Visible="true" Items="10, 20, 30, 40, 50" />
                                </SettingsPager>
                                <SettingsSearchPanel Visible="True" />
                                <Settings ShowGroupPanel="True" />
                                <Settings HorizontalScrollBarMode="Auto" />


                                <Columns>

                                    <dx:GridViewDataTextColumn Caption="CODIGO" FieldName="idPedido" VisibleIndex="1" ReadOnly="true" Width="100">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="USUARIO" FieldName="usuario" VisibleIndex="2" ReadOnly="true" Width="150">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="TIPO PEDIDO" FieldName="descripcion_pedido" VisibleIndex="3" ReadOnly="true" Width="150">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DIRECCION ORIGEN" FieldName="direccion_origen" VisibleIndex="4" ReadOnly="true" Width="250">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="DIRECCION DESTINO" FieldName="direccion_destino" VisibleIndex="5" ReadOnly="true" Width="250">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="FECHA INGRESO" FieldName="fecha_ingreso" VisibleIndex="6" ReadOnly="true" Width="150">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="COMENTARIO" FieldName="comentario" VisibleIndex="7" ReadOnly="true" Width="250">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="ESTADO" FieldName="estado" VisibleIndex="8" Width="100">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="COLABORADOR" FieldName="colaborador" VisibleIndex="9" ReadOnly="true" Width="150">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <SettingsPager>
                                    <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
                                </SettingsPager>
                            </dx:ASPxGridView>

                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
