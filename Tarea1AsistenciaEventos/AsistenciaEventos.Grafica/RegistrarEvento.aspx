<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="RegistrarEvento.aspx.cs" Inherits="AsistenciaEventos.Grafica.Formulario_web11" %>

<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row form-group">
            <div class="col-xs-6 col-sm-2">
                <asp:Label ID="Label1" runat="server" Text="Fecha del evento: "></asp:Label>
                <asp:TextBox ID="txtFechaEvento" CssClass="form-control" runat="server"></asp:TextBox>
                <ajaxToolkit:TextBoxWatermarkExtender runat="server" WatermarkText="dia/mes/año" BehaviorID="txtFechaEvento_TextBoxWatermarkExtender" TargetControlID="txtFechaEvento" ID="txtFechaEvento_TextBoxWatermarkExtender"></ajaxToolkit:TextBoxWatermarkExtender>
                <ajaxToolkit:CalendarExtender runat="server" Format="dd/MM/yyyy" BehaviorID="txtFechaEvento_CalendarExtender" TargetControlID="txtFechaEvento" ID="txtFechaEvento_CalendarExtender"></ajaxToolkit:CalendarExtender>
            </div>
        </div>

        <div class="row form-group">
            <div class="col-sm-2 col-md-4">
                <asp:Label ID="Label2" runat="server" Text="Nombre del evento: "></asp:Label>
                <asp:TextBox ID="txtNombreEvento" CssClass="form-control" runat="server"></asp:TextBox>
                <ajaxToolkit:TextBoxWatermarkExtender runat="server" WatermarkText="Como se llama el evento" BehaviorID="txtNombreEvento_TextBoxWatermarkExtender" TargetControlID="txtNombreEvento" ID="txtNombreEvento_TextBoxWatermarkExtender"></ajaxToolkit:TextBoxWatermarkExtender>
            </div>
        </div>

        <div class="row form-group">
            <div class="col-xs-6 col-sm-2">
                <asp:Button ID="btnCrearEvento" runat="server" CssClass="btn btn-primary" Text="Crear Evento" />
                <ajaxToolkit:ConfirmButtonExtender runat="server" ConfirmText="¿Está seguro de crear este evento?" BehaviorID="btnCrearEvento_ConfirmButtonExtender" TargetControlID="btnCrearEvento" ID="btnCrearEvento_ConfirmButtonExtender"></ajaxToolkit:ConfirmButtonExtender>
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
            <div class="col-sm-2 col-md-8">
                <asp:GridView ID="dgvEventos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">

                    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

                    <EditRowStyle BackColor="#7C6F57"></EditRowStyle>

                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></FooterStyle>

                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Center" BackColor="#666666" ForeColor="White"></PagerStyle>

                    <RowStyle BackColor="#E3EAEB"></RowStyle>

                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                    <SortedAscendingCellStyle BackColor="#F8FAFA"></SortedAscendingCellStyle>

                    <SortedAscendingHeaderStyle BackColor="#246B61"></SortedAscendingHeaderStyle>

                    <SortedDescendingCellStyle BackColor="#D4DFE1"></SortedDescendingCellStyle>

                    <SortedDescendingHeaderStyle BackColor="#15524A"></SortedDescendingHeaderStyle>
                </asp:GridView>
            </div>
        </div>

        <footer>
            <div class="row">
                <div class="col-lg-12">
                    <p>Copyright &copy; &nbsp;&nbsp; Alberth Garita Retana & Jose Cano Espinoza, &nbsp;&nbsp; 2017</p>
                </div>
            </div>
        </footer>
    </div>
</asp:Content>
