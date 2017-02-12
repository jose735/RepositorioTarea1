using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using AsistenciaEventos.Entidades;
using AsistenciaEventos.Logica;

namespace AsistenciaEventos.Grafica
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        MiembroLogica miembroLogica = new MiembroLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    refrescar();
            //}
        }

        public void refrescar()
        {
            dgvPadron.DataSource = miembroLogica.SeleccionarTodos();
            dgvPadron.DataBind();
        }

        protected void btnCargarExcel_Click(object sender, EventArgs e)
        {
            miembroLogica.Eliminar();
            //salvar el archivo en el sv
            string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + file.FileName).ToLower();

            file.SaveAs(Server.MapPath("~/Uploads/" + archivo));

            //Leer el excel
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(Server.MapPath("~/Uploads/" + archivo));
            Worksheet xlWorksheet = xlWorkbook.Sheets[1]; // assume it is the first sheet

            //columnas usadas
            int columnCount = xlWorksheet.UsedRange.Columns.Count;
            // int rowCount = xlWorksheet.UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
            //filas usadas
            int rowCount = xlWorksheet.UsedRange.Rows.Count;
            //resultados de cada celda de una fila
            List<string> filaExcel = new List<string>();
            //lista con los asociados del excel
            //List<Asociado> asociados = new List<Asociado>();

            //lectura de filas se omite la primera fila(titulos) y se parte de la segunda
            for (int f = 2; f <= rowCount; f++)
            {

                //lectura de cada celda del excel
                for (int c = 1; c <= columnCount; c++)
                {

                    string valorColumna = xlWorksheet.Cells[f, c].Value2;
                    filaExcel.Add(valorColumna);

                }
                //crear el asociado segun la info del list<>
                Miembro miembro = new Miembro();
                miembro.Id = filaExcel[0];
                miembro.Nombre = filaExcel[1];
                miembro.Cedula = filaExcel[2];
                miembro.Estado1 = filaExcel[3];
                miembro.Estado2 = filaExcel[4];
                miembro.Correo = filaExcel[5];
                miembro.Telefono = filaExcel[6];

                if (miembro.Id != null)
                {
                    miembroLogica.Insertar(miembro);
                }

                //asociados.Add(oAsociado);//llenaba una list de asociados
                //se limpia para meter la info de cada celda siguiente
                filaExcel.Clear();

            }

            //cerrar el excel
            xlWorkbook.Close();
            refrescar();
        }

        protected void dgvPadron_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvPadron.PageIndex = e.NewPageIndex;
            refrescar();
        }
    }
}