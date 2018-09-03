<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ConsultaPedidoOf.aspx.vb" Inherits="ConsultaPedidoOf" 
    UICulture="es" Culture="es-MX" 
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr><td>Material:</td><td><asp:TextBox ID="MaterialTxt" runat="server"  Text = "" ></asp:TextBox> </td></tr>
            <tr><td>Org.Vtas:</td><td><asp:TextBox ID="OrgVtasTxt" runat="server" Text = "1000"  ></asp:TextBox> </td></tr>
            <tr><td>Canal:</td><td><asp:TextBox ID="CanalTxt" runat="server" Text = "10"  ></asp:TextBox> </td></tr>
            <tr><td>Sector:</td><td><asp:TextBox ID="SectorTxt" runat="server" Text = "20"  ></asp:TextBox> </td></tr>
            <tr><td>Oficina Vtas:</td><td><asp:TextBox ID="OficinaTxt" runat="server" Text = "101"  ></asp:TextBox> </td></tr>
            <tr><td><asp:Button ID="ConsultarBtn" runat = "server" Text = "Consultar" /></td><td>
            <asp:Button ID="ExcelBtn" runat = "server" Text = "Exportar Excel" /></td></tr>
            <tr><td></td><td><asp:label ID="StatusLbl" runat = "server" Text = "" /></td></tr>
            <tr><td colspan = "2">
                <asp:gridview ID="Pedidos" runat = "server" AutoGenerateColumns="False" 
                    DataSourceID="PedidosOds">
                    <Columns>
                        <asp:BoundField DataField="VBELN" HeaderText="Pedido" SortExpression="VBELN" />
                        <asp:BoundField DataField="ERDAT" HeaderText="Fecha Creacion Pedido" SortExpression="ERDAT" />
                        <asp:BoundField DataField="AUDAT" HeaderText="Fecha Doc." SortExpression="AUDAT" />
                        <asp:BoundField DataField="VKORG" HeaderText="Org. Vta." SortExpression="VKORG" />
                        <asp:BoundField DataField="VTWEG" HeaderText="Canal" SortExpression="VTWEG" />
                        <asp:BoundField DataField="SPART" HeaderText="Sector" SortExpression="SPART" />
                        <asp:BoundField DataField="VKBUR" HeaderText="Oficina Vtas." SortExpression="VKBUR" />
                        <asp:BoundField DataField="KUNNR" HeaderText="Deudor" SortExpression="KUNNR" />
                        <asp:BoundField DataField="AEDAT" HeaderText="Fecha Modificacion" SortExpression="AEDAT" />
                        <asp:BoundField DataField="CUSTOMER_NAME" HeaderText="Nombre Deudor" 
                            ReadOnly="True" SortExpression="CUSTOMER_NAME" />
                        <asp:BoundField DataField="WERKS" HeaderText="CENTRO" SortExpression="WERKS" />
                        <asp:BoundField DataField="VBELN1" HeaderText="VBELN1" 
                            SortExpression="VBELN1"  Visible = "false"/>
                        <asp:BoundField DataField="POSNR" HeaderText="No. Posicion" SortExpression="POSNR" />
                        <asp:BoundField DataField="ETENR" HeaderText="No. Reparto" SortExpression="ETENR" />
                        <asp:BoundField DataField="MATNR" HeaderText="No. Material" SortExpression="MATNR" />
                        <asp:BoundField DataField="WERKS1" HeaderText="Centro" 
                            SortExpression="WERKS1" />
                        <asp:BoundField DataField="MBDAT" HeaderText="Fecha Puesta a Disposicion (OF)" SortExpression="MBDAT" />
                        <asp:BoundField DataField="LGORT" HeaderText="Almacen" SortExpression="LGORT" />
                        <asp:BoundField DataField="CHARG" HeaderText="Lote" SortExpression="CHARG" />
                        <asp:BoundField DataField="OMENG" HeaderText="Cantidad Pendiente" SortExpression="OMENG" />
                        <asp:BoundField DataField="VMENG" HeaderText="Cantidad en Libre Utilizacion" SortExpression="VMENG" />
                        <asp:BoundField DataField="PLNUM" HeaderText="No, Orden Previsional" SortExpression="PLNUM" />
                        <asp:BoundField DataField="GSMNG" HeaderText="Cantidad Orden Previsional" SortExpression="GSMNG" />
                        <asp:BoundField DataField="BDMNG" HeaderText="Cantidad Necesaria Orden Previsional" SortExpression="BDMNG" />
                    </Columns>
                </asp:gridview>
                <asp:ObjectDataSource ID="PedidosOds" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
                    TypeName="BOEDSTableAdapters.CONSULTA_PEDIDOVSOFTableAdapter">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="MaterialTxt" Name="NOMATERIAL" 
                            PropertyName="Text" Type="Int32" />
                        <asp:ControlParameter ControlID="OrgVtasTxt" Name="ORGVTA" PropertyName="Text" 
                            Type="Int32" />
                        <asp:ControlParameter ControlID="CanalTxt" Name="CANAL" PropertyName="Text" 
                            Type="Int32" />
                        <asp:ControlParameter ControlID="SectorTxt" Name="SECTOR" PropertyName="Text" 
                            Type="Int32" />
                        <asp:ControlParameter ControlID="OficinaTxt" Name="OFNAVTAS" 
                            PropertyName="Text" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td></tr>
        </table>
    </div>
    </form>
</body>
</html>
