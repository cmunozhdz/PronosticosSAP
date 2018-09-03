<%@ Page Language="VB" AutoEventWireup="false" 
    MasterPageFile="~/Site.master"
    CodeFile="PanelControl.aspx.vb" Inherits="PanelControl"%>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">



    
    <style type="text/css">
        #Detalle
        {
            top: 77px;
            left: 10px;
            height: 301px;
            width: 694px;
            margin-bottom: 0px;
        }
        p.error 
        { color :Red ;
          
        }
        p.status{color:Blue; font-family : Comic Sans MS}
    </style>


    
    <table>
    <tr>
            <td colspan="6"><div id="MensajesDiv" runat ="server"></div></td>
          </tr>
          
     <tr><td><asp:Button ID="Button1" runat="server" Text="Probar e-mail" /></td>
                <td><asp:button ID= "ActualizaConsulta" class="submit" runat ="server"  Text = "Actualizar Bitacora"/></td> 
                
                <td><asp:Button ID="BtnAdd" runat="server" Text="Agregar" /></td>
                <td colspan ="2"><asp:Button ID="BtnActualizar" runat="server" 
                        Text="Actualizar Status" Visible="False" /></td>
                
            </tr>
    <tr><td>Archivo:</td><td><input id= "Filename"  value = ""  runat ="server"/></td>
                <td>FechaIni:</td><td><input id= "FechaIni"  value = "" runat ="server"/></td>
                <td>FechaFin:</td><td><input id= "FechaFin"  value = "" runat ="server"/></td>
             
            </tr>
            <tr><td colspan ="6">DOCUMENTOS RECIBIDOS</td></tr>
            
            <tr><td colspan ="6">
                <asp:GridView ID="GrdBitacora" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ArchivosWS" DataKeyNames = "FILENAME">
                    <Columns>
                        
                        <asp:CommandField ShowSelectButton="True" 
                            SelectText="Ver &lt;br&gt;Contenido" />
                        <asp:BoundField DataField="SMDTIMESTAMP" DataFormatString="{0:dd-MMM-yyyy hh:mm:ss}" 
                            HeaderText="Fecha"  SortExpression ="SMDTIMESTAMP"/>
                        <asp:BoundField DataField="FILENAME" HeaderText="Archivo" />
                        <asp:BoundField DataField="CLAVEAGENTE" HeaderText="CLAVE DE AGENTE" 
                            SortExpression="CLAVEAGENTE"  />
                        <asp:BoundField DataField="DESC_STATUS" HeaderText="Status" />
                        <asp:BoundField DataField="STATUS" HeaderText="STATUS2" />
                        

                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate >
                                <asp:LinkButton ID="LinkProcesar" runat="server" CausesValidation="false" 
                                    CommandName="" Text="Procesar"     OnClick ="LinkProcesar" 
                                    
                                    
                                   ></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>
                </td>
            </tr>
            <tr><td colspan="6">
            <div id="Detalle" class="" 
                    
                    style="z-index: auto; overflow: auto; table-layout: auto; 
                            width: 900px; height: auto; "    >

         
                    <asp:GridView id="BitacoraArchivo"  runat = "server"   AutoGenerateColumns="False" 
            AllowPaging="True" AllowSorting="True" DataKeyNames="ID" 
            DataSourceID="ArchivosProcesadosDs"   Width ="100"  >
        <Columns>
            
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
            </div>
            </td>
            </tr>   
           
        <asp:ObjectDataSource ID="ArchivosWS" runat="server" 
            SelectMethod="ConsultaArchivoBitacora" 
            TypeName="ProxyWSSigepro.WsRecibeArchivos" 
            OldValuesParameterFormatString="original_{0}" >
            <SelectParameters>
                <asp:FormParameter FormField="Filename" Name="pstrFilename" 
                     ConvertEmptyStringToNull ="true" Type="String" />
                <asp:FormParameter  DefaultValue="01/01/2013" 
                    FormField="FechaIni" Name="FechaIni" ConvertEmptyStringToNull ="true" 
                    Type="DateTime" />
                <asp:FormParameter DefaultValue="" 
                    FormField="FechaFin" Name="FechaFin" ConvertEmptyStringToNull ="true" 
                    Type="DateTime" />
            </SelectParameters>
        </asp:ObjectDataSource>
        
        
    </table>
    
        

        <asp:ObjectDataSource ID="ArchivosProcesadosDs" runat="server" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
            TypeName="SigeproDSTableAdapters.DETALLE_ARCHIVOSTableAdapter">
            <SelectParameters>
                <asp:FormParameter DefaultValue="" FormField="Filename" Name="FILENAME" 
                    Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>

   
   
   
</asp:Content>