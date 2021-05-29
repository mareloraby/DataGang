

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
namespace DataGang
{

    public partial class Homepage : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.Button btnUpload;
        protected System.Web.UI.WebControls.Label lblUploadResult;
        protected System.Web.UI.WebControls.Panel frmConfirmation;
        protected System.Web.UI.HtmlControls.HtmlInputFile oFile;

        private void Page_Load(object sender, System.EventArgs e)
        {
            // Put user code to initialize the page here
            
        }

        override protected void OnInit(EventArgs e)
        {
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            InitializeComponent();
            base.OnInit(e);
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            this.Load += new System.EventHandler(this.Page_Load);
        }

        private void btnUpload_Click(object sender, System.EventArgs e)
        {
            string strFileName;
            string strFilePath;
            string strFolder;
            strFolder = Server.MapPath("./");
            // Get the name of the file that is posted.
            strFileName = oFile.PostedFile.FileName;
            strFileName = Path.GetFileName(strFileName);
            if (oFile.Value != "")
            {
                // Create the directory if it does not exist.
                //if (!Directory.Exists(strFolder))
                //{
                //    Directory.CreateDirectory(strFolder);
                //}
                // Save the uploaded file to the server.
                //strFilePath = strFolder + strFileName;
                //if (File.Exists(strFilePath))
                //{
                //    lblUploadResult.Text = strFileName + " already exists on the server!";

                //}
                //else
                //{
                //    oFile.PostedFile.SaveAs(strFilePath);
                //    lblUploadResult.Text = strFileName + " has been successfully uploaded.";
                //}
                Panel1.Visible = true;
            }
            else
            {
                lblUploadResult.Text = "Click 'Browse' to select the file to upload.";
                frmConfirmation.Visible = true;

            }
            // Display the result of the upload.
       
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
