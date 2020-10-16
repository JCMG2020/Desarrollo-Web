<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Colaboradores.aspx.cs" Inherits="ProyectoFinal.Colaboradores" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" style="width: 100%">
        <div class="row"  >             
            <dx:ASPxGridView ID="dxGridColaborador" runat="server" AutoGenerateColumns ="false"  ClientInstanceName="dxGridColaborador" KeyFieldName="idColaborador" SettingsBehavior-ConfirmDelete ="true"  Width="100"
           Theme="Material" OnRowInserting="dxGridColaborador_RowInserting" OnRowUpdating="dxGridColaborador_RowUpdating" OnRowDeleting="dxGridColaborador_RowDeleting">
         
            <SettingsPager PageSize="10" />            
            <EditFormLayoutProperties>
                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
            </EditFormLayoutProperties>            
            <SettingsSearchPanel Visible="true" />
            <Settings  ShowFooter="True"/>
            <SettingsCommandButton>
                    <EditButton  Text="EDITAR" />
                    <NewButton   Text="NUEVO"  />
                    <DeleteButton   Text="ELIMINAR"  />
            </SettingsCommandButton>
            <Columns>
                <dx:GridViewCommandColumn ShowEditButton="true" ShowNewButton="true" ShowDeleteButton="true" />  
                               
                <dx:GridViewDataTextColumn Caption="ID COLABORADOR" FieldName="idColaborador" VisibleIndex="1" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="NOMBRE" FieldName="nombre" VisibleIndex="2">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="APELLIDO" FieldName="apellido" VisibleIndex="3" >                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="DPI" FieldName="DPI" VisibleIndex="4">
                </dx:GridViewDataTextColumn>         
                <dx:GridViewDataTextColumn Caption="CARGO "  FieldName="cargo" VisibleIndex="5">
                </dx:GridViewDataTextColumn>
                

                <dx:GridViewDataTextColumn Caption="FECHA NACIMIENTO" FieldName="fechaNacimiento" VisibleIndex="6">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="FECHA CONTRATACION" FieldName="fechaContratacion" VisibleIndex="7">
                </dx:GridViewDataTextColumn>
                 <dx:GridViewDataTextColumn Caption="DOMICILIO" FieldName="domicilio" VisibleIndex="8">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="TELEFONO" FieldName="telefono" VisibleIndex="9">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="PLACA" FieldName="placa" VisibleIndex="10">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="ESTADO" FieldName="estado" VisibleIndex="11">
                </dx:GridViewDataTextColumn>

              
                
            </Columns>
            <SettingsPager>
                <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
            </SettingsPager>
        </dx:ASPxGridView>
        </div>
    </form>
</asp:Content>
