<%@ Page Title="" Language="C#" MasterPageFile="~/Secundaria.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoFinal.Login" %>



<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="limiter">
	<div class="container-login100">
	<div class="wrap-login100 p-l-85 p-r-85 p-t-55 p-b-55">
    <form runat="server" style="width: 100%" class="login100-form validate-form flex-sb flex-w">
        <span class="login100-form-title p-b-32">
		    Account Login
		</span>
        <span class="txt1 p-b-11">
		    E-mail
		</span>
		
            <dx:aspxtextbox id="txtCorreo" runat="server" CssClass="input100" autopostback="true">                                               
            </dx:aspxtextbox>
            <span class="focus-input100"></span>
	    
        <span class="txt1 p-b-11">
		    Password
		</span>		
		
		    <span class="btn-show-pass">
			    <i class="fa fa-eye"></i>
			</span>
            <dx:aspxtextbox id="txtContrasena" runat="server" CssClass="input100" autopostback="true">                                               
            </dx:aspxtextbox>                                            
            <span class="focus-input100"></span>

		
        <div class="container-login100-form-btn">
            <dx:ASPxButton ID="dxBtnAceptar" runat="server" Text="LOGIN"  onClick="dxBtnAceptar_Click" CssClass="login100-form-btn" >                                                       
            </dx:ASPxButton> 
        </div>

        <span class="txt1 p-b-11">
            <asp:Label ID="lb_error" runat="server" Text=""></asp:Label>
		    
		</span>

    </form>
    </div>
    </div>
    
    
</asp:Content>
