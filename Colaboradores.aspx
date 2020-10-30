<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Colaboradores.aspx.cs" Inherits="ProyectoFinal.Colaboradores" %>


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

                        <dx:ASPxGridView ID="dxGridColaborador" runat="server" AutoGenerateColumns="false" KeyFieldName="idColaborador" Width="100%"
                            Theme="Material" OnRowInserting="dxGridColaborador_RowInserting" OnRowUpdating="dxGridColaborador_RowUpdating" OnRowDeleting="dxGridColaborador_RowDeleting" OnCellEditorInitialize="dxGridColaborador_CellEditorInitialize">

                            <SettingsEditing Mode="EditForm"></SettingsEditing>
                            <SettingsPager NumericButtonCount="10" PageSize="10"></SettingsPager>
                            <SettingsPager>
                                <PageSizeItemSettings Visible="true" Items="10, 20, 30, 40, 50" />
                            </SettingsPager>
                            <SettingsSearchPanel Visible="True" />
                            <Settings ShowGroupPanel="True" />
                            <Settings HorizontalScrollBarMode="Auto" />


                            <SettingsCommandButton>
                                <EditButton Text="EDITAR" />
                                <NewButton Text="NUEVO" />
                                <DeleteButton Text="ELIMINAR" />
                            </SettingsCommandButton>
                            <Columns>
                                <dx:GridViewCommandColumn ShowEditButton="true" VisibleIndex="1" ShowDeleteButton="True" ShowNewButtonInHeader="True" Width="200" />

                                <dx:GridViewDataTextColumn Caption="ID COLABORADOR" FieldName="idColaborador" VisibleIndex="1" ReadOnly="true" Width="150">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="NOMBRE" FieldName="nombre" VisibleIndex="2" Width="250">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="APELLIDO" FieldName="apellido" VisibleIndex="3" Width="250">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="DPI" FieldName="DPI" VisibleIndex="4" Width="150">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn FieldName="idCargo" Caption="Cargo" VisibleIndex="5">
                                    <PropertiesComboBox ValueField="idCargo" TextField="cargo" ValueType="System.Int32">
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <%--   <dx:GridViewDataTextColumn Caption="CARGO "  FieldName="idCargo" VisibleIndex="5">
                </dx:GridViewDataTextColumn>--%>
                                <dx:GridViewDataTextColumn Caption="CARGO " FieldName="cargo" VisibleIndex="6">
                                </dx:GridViewDataTextColumn>


                                <dx:GridViewDataTextColumn Caption="FECHA NACIMIENTO" FieldName="fechaNacimiento" VisibleIndex="7" Width="150">
                                    <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy"></PropertiesTextEdit>
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>

                                <dx:GridViewDataTextColumn Caption="FECHA CONTRATACION" FieldName="fechaContratacion" VisibleIndex="8" Width="150">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="DOMICILIO" FieldName="domicilio" VisibleIndex="9" Width="300">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="TELEFONO" FieldName="telefono" VisibleIndex="10" Width="100">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="PLACA" FieldName="placa" VisibleIndex="11">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="ESTADO" FieldName="estado" VisibleIndex="12">
                                </dx:GridViewDataTextColumn>



                            </Columns>
                            <SettingsPager>
                                <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
                            </SettingsPager>

                            <Settings ShowFilterRow="true" />

                            <SettingsEditing Mode="Batch" EditFormColumnCount="1">
                                <BatchEditSettings StartEditAction="Click" />
                            </SettingsEditing>
                        </dx:ASPxGridView>



                    </form>
                </div>
            </div>
        </div>
    </div>





    <script language="javascript" type="text/javascript">
        document.getElementById('divGrid').style.width = screen.width + "px";
    </script>





</asp:Content>
