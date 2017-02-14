<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ReporteMiembrosPorEvento.aspx.cs" Inherits="AsistenciaEventos.Grafica.Formulario_web16" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="text-center">Pantalla de informe de eventos</h2>
        <h4 class="text-center">Por favor, seleccione el evento para el cual se generará el informe y cliquée el botón de consulta</h4>
        <div class="row form-group">
            <div class="col-xs-4 col-sm-3">
                <asp:Label ID="Label1" runat="server" Text="Evento: "></asp:Label>
                <asp:DropDownList ID="ddlEvento" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
            <div class="col-xs-4 col-sm-2">
                <br />
                <asp:Button ID="btnBuscar" CssClass="btn btn-success" runat="server" Text="Consultar" OnClick="btnBuscar_Click" />
            </div>
        </div>
        <div class="row form-group text-center">
            <div class="col-sm-2 col-md-8">
                <div class="alert alert-info" runat="server" id="cajaError" visible="false">
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-xs-12 col-md-12">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="988px">
                    <LocalReport ReportPath="repEventos.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource Name="DataSet1" DataSourceId="ObjectDataSource1"></rsweb:ReportDataSource>
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
                <asp:ObjectDataSource runat="server" SelectMethod="SeleccionarMiembrosPorEvento" TypeName="AsistenciaEventos.Logica.MiembroLogica" ID="ObjectDataSource1">
                    <SelectParameters>
                        <asp:ControlParameter DefaultValue="" Name="idEvento" Type="Int32" ControlID="ddlEvento" PropertyName="SelectedValue"></asp:ControlParameter>
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <!-- Footer -->
        <footer>
            <div class="row">
                <div class="col-lg-12">
                    <p>Copyright &copy; &nbsp;&nbsp; Alberth Garita Retana & Jose Cano Espinoza, &nbsp;&nbsp; 2017</p>
                </div>
            </div>
        </footer>
    </div>
</asp:Content>
