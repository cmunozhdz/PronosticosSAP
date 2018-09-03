<%@ Page Title="Página principal" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
       Pagina de Inicio Pronosticos de Ventas grupo Polak
    </h2>
    <p>
        Este sitio provee webservices para la intercomunicacion de clientes 
        con el sistema centralizado de pronosticos.
    </p>
    <p>
        Contacte al area de sistemas para mayor informacion.
        <br />
        <textarea ID="MensajeTextBox" runat="server" rows = "30" cols="100">
        </textarea><br />
        
        <asp:Button ID="EnviarBtn" runat="server" Text="Enviar" />

    </p>
</asp:Content>