

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
using System.Diagnostics;
using System.Threading.Tasks;
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
            Label1.Text = "";
            //summary_label.Text = "";
            //Process.Start("C:\test.bat");
            //string impath = "D:/Projects/Bayer/train_classes/Backmoth/Backmoth3.jpg";
            //string prog = Server.MapPath("./cabbage.py");
            //test_space.Text = EntryPoint.func(prog, impath);
            //proc.WaitForExit();
            //Console.ReadLine();

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
            strFolder = Server.MapPath("./uploads/");
            // Get the name of the file that is posted.
            strFileName = oFile.PostedFile.FileName;
            strFileName = Path.GetFileName(strFileName);
            if (oFile.Value != "")
            {
                // Create the directory if it does not exist.
                if (!Directory.Exists(strFolder))
                {
                    Directory.CreateDirectory(strFolder);
                }
                // Save the uploaded file to the server.
                strFilePath = strFolder + strFileName;
                if (File.Exists(strFilePath))
                {
                    Label1.Text = "You've already uploaded " + strFileName;

                }
                else
                {
                    String planttype = "";
                    oFile.PostedFile.SaveAs(strFilePath);
                    if (DropDownList1.SelectedItem.Text.Contains("Plant type")) { Label1.Text = "Please choose plant type"; }
                    else
                    {

                        planttype=DropDownList1.SelectedItem.Text;


                    
                    //string impath = "D:/Projects/Bayer/train_classes/Backmoth/Backmoth3.jpg";
                    //impath = "C:/Users/salma/Source/Repos/DataGang/DataGang/uploads/Late_Blight (461).jpg";
                    string dire = Server.MapPath(string.Concat("./uploads/"+ strFileName));
                    System.Diagnostics.Debug.WriteLine(dire);
                    string newdire = dire.Replace("\\", "/");
                    System.Diagnostics.Debug.WriteLine(newdire);
                        string prog = "";
                        
                        switch (planttype){
                            case "Cabbage":  prog = Server.MapPath("./cabbage.py"); break;
                            case "Apple":  prog = Server.MapPath("./fruit.py"); break;
                            case "Tomato":  prog = Server.MapPath("./tomato.py"); break;
                            case "Grapes":  prog = Server.MapPath("./fruit.py"); break;
                            case "Potato":  prog = Server.MapPath("./potato.py"); break;
                            default: Label1.Text = "please select a plant type"; break;

                        }


                        String diagnosis = EntryPoint.func(prog, newdire);

                        Label1.Text = diagnosis;
                        string infoprog = Server.MapPath("./summary_link.py");
                        if (diagnosis.ToLower().Trim().Contains("health") == false)
                        {
                            System.Diagnostics.Debug.WriteLine("diagnosis.ToLower().Trim()");

                            string summary_info = EntryPoint.get_info_python(infoprog, diagnosis.Trim());
                            System.Diagnostics.Debug.WriteLine(summary_info);

                            summary_label.Text = summary_info;
                        }
                        //Label1.Text = strFileName + " has been successfully uploaded.";
                    }
                }
                // Panel1.Visible = true;
            }
            else
            {
                //lblUploadResult.Text = "Click 'Browse' to select the file to upload.";
                Label1.Text = "Upload a photo first.";

                frmConfirmation.Visible = true;

            }
            // Display the result of the upload.

        }


 
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }

    public partial class EntryPoint
    {
        public static string func(string prog, string impath)
        {

            int x = 1;
            int y = 2;
            string progToRun = prog;
            //"hello.py";
            char[] splitter = { '\r' };

            Process proc = new Process();
            proc.StartInfo.FileName = "python.exe";
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;

            // call hello.py to concatenate passed parameters
            //proc.StartInfo.Arguments = string.Concat(progToRun, " ", x.ToString(), " ", y.ToString());
            proc.StartInfo.Arguments = string.Concat(progToRun, " ", impath);
            proc.Start();

            StreamReader sReader = proc.StandardOutput;
            string[] output = sReader.ReadToEnd().Split(splitter);

            foreach (string s in output)
                System.Diagnostics.Debug.WriteLine(s);

            proc.WaitForExit();
            proc.Close();
            //Console.ReadLine();
            return output[0];
        }

        public static string get_info_python(string prog, string impath)
        {

            int x = 1;
            int y = 2;
            string progToRun = prog;
            //"hello.py";
            char[] splitter = { '\r' };

            Process proc = new Process();
            proc.StartInfo.FileName = "python.exe";
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;

            // call hello.py to concatenate passed parameters
            //proc.StartInfo.Arguments = string.Concat(progToRun, " ", x.ToString(), " ", y.ToString());
            proc.StartInfo.Arguments = string.Concat(progToRun, " ", impath);
            proc.Start();

            StreamReader sReader = proc.StandardOutput;
            string[] output = sReader.ReadToEnd().Split(splitter);

            foreach (string s in output)
                System.Diagnostics.Debug.WriteLine(s);

            proc.WaitForExit();
            proc.Close();
            //Console.ReadLine();
            return output[0];
        }
    }

}
