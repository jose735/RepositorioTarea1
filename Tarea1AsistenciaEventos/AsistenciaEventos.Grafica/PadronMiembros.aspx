<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PadronMiembros.aspx.cs" Inherits="AsistenciaEventos.Grafica.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row form-group">
            <div class="col-sm-2 col-md-4">
                <asp:FileUpload ID="file" runat="server" CssClass="btn btn-default" />
                <br />
                <asp:Button ID="btnCargarExcel" runat="server" Text="Cargar Padrón de Miembros" CssClass="btn btn-primary" OnClick="btnCargarExcel_Click" />
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-6 col-lg-10">
                <asp:GridView ID="dgvPadron" CssClass="table table-responsive" AutoGenerateColumns="false" AllowPaging="true" PageSize="5" OnPageIndexChanging="dgvPadron_PageIndexChanging" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="N&#250;mero de Miembro"></asp:BoundField>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre"></asp:BoundField>
                        <asp:BoundField DataField="Cedula" HeaderText="C&#233;dula"></asp:BoundField>
                        <asp:BoundField DataField="Estado1" HeaderText="Estado 1"></asp:BoundField>
                        <asp:BoundField DataField="Estado2" HeaderText="Estado 2"></asp:BoundField>
                        <asp:BoundField DataField="Correo" HeaderText="Correo"></asp:BoundField>
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono"></asp:BoundField>
                    </Columns>
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
