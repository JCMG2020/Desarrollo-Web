﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="ProyectoFinal.Pedidos" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" style="width: 100%">
    <div class="contenedor" id="contenedor">          
    <dx:ASPxGridView ID="dxGridPedido" runat="server"  AutoGenerateColumns="false"  ClientInstanceName="dxGridPedido" KeyFieldName="idPedido" SettingsBehavior-ConfirmDelete ="true"  Width="100px" Theme="Material">
            
            <SettingsPager PageSize="10" />       
            <Settings HorizontalScrollBarMode="Auto" />
            <EditFormLayoutProperties>
                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
            </EditFormLayoutProperties>            
            <SettingsSearchPanel Visible="true" />
            <Settings  ShowFooter="True"/>

            <Columns>
                                           
                <dx:GridViewDataTextColumn Caption="CODIGO" FieldName="idPedido" VisibleIndex="1" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="USUARIO" FieldName="usuario" VisibleIndex="2" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="TIPO PEDIDO" FieldName="descripcion_pedido" VisibleIndex="3" ReadOnly="true">
                </dx:GridViewDataTextColumn>               
                <dx:GridViewDataTextColumn Caption="DIRECCION ORIGEN" FieldName="direccion_origen" VisibleIndex="4" ReadOnly="true">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="DIRECCION DESTINO" FieldName="direccion_destino" VisibleIndex="5" ReadOnly="true">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="FECHA INGRESO" FieldName="fecha_ingreso" VisibleIndex="6" ReadOnly="true">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="COMENTARIO" FieldName="comentario" VisibleIndex="7" ReadOnly="true">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="ESTADO" FieldName="estado" VisibleIndex="8">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="COLABORADOR" FieldName="colaborador" VisibleIndex="9" ReadOnly="true">
                </dx:GridViewDataTextColumn>
            </Columns>
            <SettingsPager>
                <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
            </SettingsPager>
        </dx:ASPxGridView>
        
    </div>
        </form>
</asp:Content>
