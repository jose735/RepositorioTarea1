<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="AsistenciaEventos.Grafica.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">

        <!-- Heading Row -->
        <div class="row">
            <div class="col-md-8">
                <img class="img-responsive img-rounded" src="Imagenes/img-1.jpg" alt="">
            </div>
            <!-- /.col-md-8 -->
            <div class="col-md-4">
                <h1>Registro de eventos y asistencia de miembros</h1>
                <p>Esta es una página que se encarga de la creación de eventos de cualquier tipo. Este tambien se encarga del control de asistencia de los miembros que se encuentren registrados en esta página como usuarios</p>
                <a class="btn btn-primary btn-lg" href="RegistrarAsistencia.aspx">Asistir a un evento</a>
            </div>
            <!-- /.col-md-4 -->
        </div>
        <!-- /.row -->

        <hr>

        <!-- Call to Action Well -->
        <div class="row">
            <div class="col-lg-12">
                <div class="well text-center">
                    Todos los eventos que quieras crear y controlar puedes manejarlos aqui!
                </div>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->

        <!-- Content Row -->
        <div class="row">
            <div class="col-md-4">
                <h2>Registrar Eventos</h2>
                <p>Se encarga de la creacion de eventos dando a conocer la fecha en la que se dara a cabo el evento y el nombre de dicho evento. Se pueden crear los eventos que quieras.</p>
                <a class="btn btn-default" href="RegistrarEvento.aspx">Ir a crear evento</a>
            </div>
            <!-- /.col-md-4 -->
            <div class="col-md-4">
                <h2>Registrar Asistencia</h2>
                <p>Aquí puedes seleccionar el evento que tu creaste o el que otros crearosn y registrar tu asistencia en él. Para ellos ya debiste ser un usuario de la página y buscarte por medio de tú código de membresia, revisa tus datos y confirma tu asistencia.</p>
                <a class="btn btn-default" href="RegistrarAsistencia.aspx">Ir a registro de asistencia</a>
            </div>
            <!-- /.col-md-4 -->
            <div class="col-md-4">
                <h2>Reporte de asistencia de miembros</h2>
                <p>Esta opción te permite ver a los miembros que participaron en el evento que desees buscar e incluso puedes descargar ese informe con el fin de tener un respaldo de las personas que llegaron a tu evento.</p>
                <a class="btn btn-default" href="#">Ir a reporte</a>
            </div>
            <!-- /.col-md-4 -->
        </div>
        <!-- /.row -->

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
