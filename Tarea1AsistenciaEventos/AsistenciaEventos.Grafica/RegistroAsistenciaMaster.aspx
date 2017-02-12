<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RegistroAsistenciaMaster.aspx.cs" Inherits="AsistenciaEventos.Grafica.Formulario_web14" %>

<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row form-group">
            <div class="col-sm-2 col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Lista de eventos disponibles: "></asp:Label>
                <asp:DropDownList ID="ddlEventos" CssClass="form-control" runat="server"></asp:DropDownList>
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
            <div class="col-xs-6 col-sm-2">
                <asp:Button ID="btnBuscarMiembro" CssClass="btn btn-primary" Visible="false" runat="server" Text="Buscar Miembro" />
            </div>
        </div>

        <div class="row form-group" runat="server" id="cajaRegistroMiembro" visible="false">
            <div class="col-sm-4 col-md-8">
                <div class="col-sm-2 col-md-6">
                    <asp:Label ID="Label2" runat="server" Text="Número de identificación: "></asp:Label>
                    <asp:TextBox ID="txtIdentificacion" CssClass="form-control" runat="server"></asp:TextBox>
                    <ajaxToolkit:TextBoxWatermarkExtender runat="server" WatermarkText="Cédula o Número de miembro" BehaviorID="txtIdentificacion_TextBoxWatermarkExtender" TargetControlID="txtIdentificacion" ID="txtIdentificacion_TextBoxWatermarkExtender"></ajaxToolkit:TextBoxWatermarkExtender>
                </div>
                <div class="col-sm-2 col-md-6">
                    <asp:Label ID="Label3" runat="server" Text="Nombre: "></asp:Label>
                    <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row form-group" runat="server" id="cajaRegistroMiembro2" visible="false">
            <div class="col-sm-4 col-md-8">
                <div class="col-sm-2 col-md-4">
                    <asp:Label ID="Label5" runat="server" Text="Estado: "></asp:Label>
                    <asp:TextBox ID="txtEstado" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                </div>
                <div class="col-sm-2 col-md-4">
                    <asp:Label ID="Label4" runat="server" Text="Correo: "></asp:Label>
                    <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                </div>
                <div class="col-sm-2 col-md-4">
                    <asp:Label ID="Label6" runat="server" Text="Teléfono: "></asp:Label>
                    <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row form-group">
            <div class="col-xs-6 col-sm-2" runat="server" id="cajaRegistroMiembro3" visible="false">
                <asp:Button ID="btnRegistrarMiembro" CssClass="btn btn-primary" runat="server" Text="Registrar Asistencia" />
            </div>

            <div class="col-xs-6 col-sm-2">
                <asp:Button ID="btnCierreMesa" CssClass="btn btn-default" runat="server" Text="Cierre de Mesa" />
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
