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


namespace AsistenciaEventos.Grafica
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        public string DefaultFileName = "Upload/";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUploader.HasFile)
                try
                {
                    FileUploader.SaveAs(Server.MapPath(DefaultFileName) +
                         FileUploader.FileName);
                    Label1.Text = "File name: " +
                         FileUploader.PostedFile.FileName + "<br>" +
                         FileUploader.PostedFile.ContentLength + " kb<br>" +
                         "Content type: " +
                         FileUploader.PostedFile.ContentType + "<br><b>Uploaded Successfully";

                }
                catch (Exception ex)
                {
                    Label1.Text = "ERROR: " + ex.Message.ToString();
                }
            else
            {
                Label1.Text = "You have not specified a file.";
            }
        }
    }
}