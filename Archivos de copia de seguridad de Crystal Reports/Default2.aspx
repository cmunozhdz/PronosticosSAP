<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2"%>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Detalle
        {
            top: 77px;
            left: 10px;
            height: 301px;
            width: 1275px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table><tr><td>Archivo:<input id= "Filename"  value = ""  runat ="server"/></td>
                <td>FechaIni:<input id= "FechaIni"  value = "" runat ="server"/></td>
                <td>FechaFin:<input id= "FechaFin"  value = "" runat ="server"/><asp:Button 
                        ID="Button1" runat="server" Text="Correo" />
        </td>
            </tr>
            <tr><td colspan ="3"><input id="BtnSubmit" type ="submit" /><asp:Button ID="BtnAdd" 
                    runat="server" Text="Agregar" />
                </td>
            </tr>
           <tr><td colspan ="3">Archivo:
           </td><td colspan ="3"><asp:ListBox ID="ListBox1" runat="server" 
            DataSourceID="ArchivosWS" DataTextField="FILENAME" DataValueField="FILENAME" 
                   Width="494px">
        </asp:ListBox>
        <asp:ObjectDataSource ID="ArchivosWS" runat="server" 
            SelectMethod="ConsultaArchivoBitacora" 
            TypeName="ProxyWSSigepro.WsRecibeArchivos">
            <SelectParameters>
                <asp:FormParameter FormField="Filename" Name="pstrFilename" 
                    DbType="String" DefaultValue=""  ConvertEmptyStringToNull ="true" />
                <asp:FormParameter DbType="DateTime" DefaultValue="01/01/2013" 
                    FormField="FechaIni" Name="FechaIni" ConvertEmptyStringToNull ="true" />
                <asp:FormParameter DbType="DateTime" DefaultValue="31/12/2100" 
                    FormField="FechaFin" Name="FechaFin" ConvertEmptyStringToNull ="true" />
            </SelectParameters>
        </asp:ObjectDataSource>
        </td>
        </tr> 
    </table>
    
        <div id="Detalle" class="" 
        style="font-family: Arial, Helvetica, sans-serif; 
                font-size: medium; 
                border-style: solid; 
                z-index: auto; overflow: auto" >

    <asp:GridView id="BitacoraArchivo"  runat = "server"   AutoGenerateColumns="False" 
            AllowPaging="True" AllowSorting="True" DataKeyNames="ID" 
            DataSourceID="ArchivosProcesadosDs" >
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="IDPRONOSTICO" HeaderText="IDPRONOSTICO" 
                SortExpression="IDPRONOSTICO" />
            <asp:BoundField DataField="INTPERIODO" HeaderText="INTPERIODO" 
                SortExpression="INTPERIODO" />
            <asp:BoundField DataField="CLAVEAGENTE" HeaderText="CLAVEAGENTE" 
                SortExpression="CLAVEAGENTE" />
            <asp:BoundField DataField="CLAVEZONA" HeaderText="CLAVEZONA" 
                SortExpression="CLAVEZONA" />
            <asp:BoundField DataField="SMDINICIO" HeaderText="SMDINICIO" 
                SortExpression="SMDINICIO" />
            <asp:BoundField DataField="CLAVECENTRO" HeaderText="CLAVECENTRO" 
                SortExpression="CLAVECENTRO" />
            <asp:BoundField DataField="CLAVEALMACEN" HeaderText="CLAVEALMACEN" 
                SortExpression="CLAVEALMACEN" />
            <asp:BoundField DataField="CLAVEPRODUCTO" HeaderText="CLAVEPRODUCTO" 
                SortExpression="CLAVEPRODUCTO" />
            <asp:BoundField DataField="UNIDADMEDIDABASE" HeaderText="UNIDADMEDIDABASE" 
                SortExpression="UNIDADMEDIDABASE" />
            <asp:BoundField DataField="NUMCANTIDADBASE" HeaderText="NUMCANTIDADBASE" 
                SortExpression="NUMCANTIDADBASE" />
            <asp:BoundField DataField="UNIDADMEDIDAALTERNA" 
                HeaderText="UNIDADMEDIDAALTERNA" SortExpression="UNIDADMEDIDAALTERNA" />
            <asp:BoundField DataField="NUMCANTIDADALTERNA" HeaderText="NUMCANTIDADALTERNA" 
                SortExpression="NUMCANTIDADALTERNA" />
            <asp:BoundField DataField="CLAVESOCIEDAD" HeaderText="CLAVESOCIEDAD" 
                SortExpression="CLAVESOCIEDAD" />
            <asp:BoundField DataField="CLAVECLIENTE" HeaderText="CLAVECLIENTE" 
                SortExpression="CLAVECLIENTE" />
            <asp:CheckBoxField DataField="CANTIDADEXACTA" HeaderText="CANTIDADEXACTA" 
                SortExpression="CANTIDADEXACTA" />
            <asp:BoundField DataField="SMDTIMESTAMP" HeaderText="SMDTIMESTAMP" 
                SortExpression="SMDTIMESTAMP" />
            <asp:BoundField DataField="SMDTIMECONVERTIDO" HeaderText="SMDTIMECONVERTIDO" 
                SortExpression="SMDTIMECONVERTIDO" />
            <asp:BoundField DataField="STATUS" HeaderText="STATUS" 
                SortExpression="STATUS" />
            <asp:BoundField DataField="FILENAME" HeaderText="FILENAME" 
                SortExpression="FILENAME" />
        </Columns>



    </asp:GridView>

        <asp:ObjectDataSource ID="ArchivosProcesadosDs" runat="server" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
            TypeName="SigeproDSTableAdapters.DETALLE_ARCHIVOSTableAdapter">
            <SelectParameters>
                <asp:FormParameter DefaultValue="" FormField="Filename" Name="FILENAME" 
                    Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
    </form>
</body>
</html>
