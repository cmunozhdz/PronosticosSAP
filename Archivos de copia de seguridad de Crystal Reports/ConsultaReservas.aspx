<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ConsultaReservas.aspx.vb" Inherits="ConsultaReservas" 
        UICulture="es" Culture="es-MX" 
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  >
    <form id="form1" runat="server" >
    <div>
    <table><tr ><th colspan="2">Consulta Reservas de Inventarios</th></tr>
    <tr><td>Centro:</td><td> <asp:TextBox ID="CentroTxt" runat="server" ToolTip = "Indique el numero del centro a consultar separado por comas (,)"></asp:TextBox> </td></tr>
    <tr><td>Tipo de Material:</td><td> <asp:TextBox ID="TipoMaterialTxt" runat="server" ToolTip = "Indique el tipo de material a consultar separado por comas (,)" ></asp:TextBox> </td></tr>
    <tr><td>No Material:</td><td> <asp:TextBox ID="NoMaterialTxt" runat="server" ToolTip = "Indique clave del material"  ></asp:TextBox>  </td></tr>
    <tr><td>Descripcion Material:</td><td> <asp:TextBox ID="DescMaterialTxt" ToolTip = "Indique  con * para hacer busquedas globales"   runat="server"></asp:TextBox> </td></tr>
    <tr><td colspan ="2">
        <asp:Label ID="StatusLbl" runat ="server" Text = ""></asp:Label>
        </td></tr>
    <tr><td >
        <asp:Button ID="Button1" runat="server" Text="Consultar" />
        </td>
        <td >
        <asp:Button ID="ExxportaBtn" runat="server" Text="ExportarExcel" />
        </td>
        
        </tr>

     <tr><td colspan = "2">
         <asp:GridView ID="ReservasGrd" runat="server" AutoGenerateColumns="False" 
             DataSourceID="ReservasOds">
             <Columns>
                 <asp:BoundField DataField="MANDT" HeaderText="MANDT" SortExpression="MANDT"  Visible = "false"/>
                 <asp:BoundField DataField="MATNR" HeaderText="No. Material" ReadOnly="True"  
                     SortExpression="MATNR" />
                 <asp:BoundField DataField="MTART" HeaderText="Tipo" SortExpression="MTART" />
                 <asp:BoundField DataField="MEINS" HeaderText="U.D.M" SortExpression="MEINS" />
                 <asp:BoundField DataField="MAKTX" HeaderText="Descripcion" SortExpression="MAKTX" />
                 <asp:BoundField DataField="WERKS" HeaderText="Centro" SortExpression="WERKS" />
                 <asp:BoundField DataField="LVORM" HeaderText="LVORM" SortExpression="LVORM"  visible="false"/>
                 <asp:BoundField DataField="LGORT" HeaderText="Almacen" SortExpression="LGORT" />
                 <asp:BoundField DataField="CHARG" HeaderText="Lote" SortExpression="CHARG" />
                 <asp:BoundField DataField="CLABS" HeaderText="Libre Utilizacion" SortExpression="CLABS" />
                 <asp:BoundField DataField="SALDORESERVA" HeaderText="Reserva" 
                     SortExpression="SALDORESERVA" />
             </Columns>
         </asp:GridView>
         <asp:ObjectDataSource ID="ReservasOds" runat="server" 
             OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
             TypeName="BOEDSTableAdapters.CONSULTARESERVASTableAdapter">
             <SelectParameters>
                 <asp:ControlParameter ControlID="CentroTxt" Name="CENTRO" PropertyName="Text" 
                     Type="String" />
                 <asp:ControlParameter ControlID="TipoMaterialTxt" Name="TIPOMATERIAL" 
                     PropertyName="Text" Type="String" />
                 <asp:ControlParameter ControlID="NoMaterialTxt" Name="NOMATERIAL" 
                     PropertyName="Text" Type="Int32" />
                 <asp:ControlParameter ControlID="DescMaterialTxt" Name="DESCMATERIAL" 
                     PropertyName="Text" Type="String" />
             </SelectParameters>
         </asp:ObjectDataSource>
         </td> </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
