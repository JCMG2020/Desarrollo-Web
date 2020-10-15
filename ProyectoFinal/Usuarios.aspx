<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ProyectoFinal.Usuarios" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" style="width: 100%">
        <div class="row"  >             
            <dx:ASPxGridView ID="dxGridUsuario" runat="server" AutoGenerateColumns ="false"  ClientInstanceName="dxGridUsuario" KeyFieldName="idUsuario" SettingsBehavior-ConfirmDelete ="true"  Width="100"
           Theme="Material">
         
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
                               
                <dx:GridViewDataTextColumn Caption="ID USUARIO" FieldName="idUsuario" VisibleIndex="1" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="USUARIO" FieldName="usuario_alias" VisibleIndex="1" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>

                <dx:GridViewDataTextColumn Caption="NOMBRE" FieldName="nombre" VisibleIndex="3">
                </dx:GridViewDataTextColumn>         
                <dx:GridViewDataTextColumn Caption="APELLIDOS" FieldName="apellido" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="EMAIL" FieldName="email" VisibleIndex="5">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="CONTRASENA" FieldName="contrasena" VisibleIndex="6">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="DPI" FieldName="DPI" VisibleIndex="6">
                </dx:GridViewDataTextColumn>
      

                
            </Columns>
            <SettingsPager>
                <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
            </SettingsPager>
        </dx:ASPxGridView>
        </div>
    </form>
</asp:Content>
