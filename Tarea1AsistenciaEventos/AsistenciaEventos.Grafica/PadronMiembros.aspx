<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PadronMiembros.aspx.cs" Inherits="AsistenciaEventos.Grafica.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        Select File &nbsp;<asp:FileUpload ID="FileUploader" runat="server" /><br />
        <br />
        <asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick="UploadButton_Click" /><br />
        <br />
         <asp:Label ID="Label1" runat="server"></asp:Label><br />

</div>
</asp:Content>
