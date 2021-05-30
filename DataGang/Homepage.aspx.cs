

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
        String diagnosis;
        //String planttype = "";

        private void Page_Load(object sender, System.EventArgs e)
        {
            // Put user code to initialize the page here
            Label1.Text = "";
            Labelsummary.Text = "";
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
                    oFile.PostedFile.SaveAs(strFilePath);
                    if (DropDownList1.SelectedItem.Text.Contains("Plant type")) { Label1.Text = "Please choose plant type"; }
                    else
                    {

                        String planttype=DropDownList1.SelectedItem.Text;


                    
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

                        
                          diagnosis = EntryPoint.func(prog, newdire);
                          Session["field1"] = diagnosis;



                        Label1.Text = diagnosis.Replace("_", " ");
                        string infoprog = Server.MapPath("./summary_link.py");
                        if (diagnosis.ToLower().Trim().Contains("health") == false)
                        {
                            System.Diagnostics.Debug.WriteLine(diagnosis.ToLower().Trim());

                            string summary_info = EntryPoint.get_info_python(infoprog, diagnosis.Trim());
                            System.Diagnostics.Debug.WriteLine(summary_info);
                            summary_info = summary_info.Replace("\n", "\n ");
                            Labelsummary.Text = summary_info;
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

        protected void btnTreat_Click(object sender, EventArgs e)
        {
            tuple[] treat = new tuple[15];


            treat[0] = new tuple("Apple", "Apple scab", "Bonide®️ Sulfur Plant Fungicide", "Organocide®️ Plant Doctor", "Bonide®️ Orchard Spray");
            treat[1] = new tuple("Apple", "Black_rot", "Fungicide spray", "copper-based fungicide", "");
            treat[2] = new tuple("Apple", "Gymnosporangium", "Immunox", "", "");
            treat[3] = new tuple("Grapes", "Black_rot", "captan", "myclobutanil", "");
            treat[4] = new tuple("Grapes", "Esca_Black_Measles", "Removed and burned", "", "");
            treat[5] = new tuple("Grapes", "Isariopsis_Leaf_Spot", "Bonide®️ Sulfur Plant Fungicide", "Organocide®️ Plant Doctor", "");
            treat[6] = new tuple("Tomato", "Bacterial_spot", "Infected plant should be removed and burned", "", "");
            treat[7] = new tuple("Tomato", "Black_mold", "Daconil®️ fungicides", "Daconi", "");
            treat[8] = new tuple("Tomato", "Gray_spot", "copper spray", "Serenade", "chlorothalonil");
            treat[9] = new tuple("Tomato", "Late_blight", "copper spray", "Serenade", "chlorothalonil");
            treat[10] = new tuple("Tomato", "Powdery_mildew", "copper spray", "Serenade", "chlorothalonil");
            treat[11] = new tuple("Cabbage", "Diamondback_moth", "copper spray", "Serenade", "chlorothalonil");
            treat[12] = new tuple("Cabbage", "Leafminer", "copper spray", "Serenade", "chlorothalonil");
            treat[13] = new tuple("Cabbage", "Mildew", "copper spray", "Serenade", "chlorothalonil");
            // treat[14] = new tuple("Potato", "Healthy potato", "", "", "");
            treat[14] = new tuple("Potato", "potato_late_blight", "copper spray", "Serenade", "chlorothalonil");

            String treatment = "You may try: ";
            String planttype2 = DropDownList1.SelectedItem.Text;
            String diagnosis1 = (String) Session["field1"]; 

            for (int i = 0; i < treat.Length; i++)

            {

                System.Diagnostics.Debug.WriteLine(treat[i].disease);
                System.Diagnostics.Debug.WriteLine(diagnosis1);

                if (treat[i].crop.Equals(planttype2) && treat[i].disease.Equals(diagnosis1))
                {
                   

                    if (!treat[i].med1.Equals(""))
                    {
                        treatment += treat[i].med1;
                    }

                    if (!treat[i].med2.Equals(""))
                    {
                        treatment += ", " + treat[i].med2;
                    }
                    if (!treat[i].med3.Equals(""))
                    {
                        treatment += ", " + treat[i].med3;
                    }


                }

            }

            lbltreat.Text = treatment;


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
            //return "Mildew";
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
            //return "(In Old English, mildew meant honeydew (a substance secreted by aphids on leaves, formerly thought to distill from the air like dew), and later came to mean mould or fungus.\n Mould growth found on cellulose-based substrates or materials where moisture levels are high (90 percent or greater) is often Stachybotrys chartarum.\n Glass, plastic, and concrete provide no food for organic growth and as such cannot support mould or mildew growth alone without bio-film present.\n == Environmental conditions ==\n The requirements are a food source (any organic material), sufficient ambient moisture (a relative humidity of between 62 and 93 percent), and reasonable warmth (77 °F (25 °C) to 88 °F (31 °C) is optimal, but some growth can occur anywhere between freezing and 95 °F (35 °C)).\n Preventing the growth of mildew therefore requires a balance between moisture and temperature.\n Air temperatures at or below 70 °F (21 °C) will inhibit growth, but only if the relative humidity is low enough to prevent water condensation (i.e., the dew point is not reached).\n Warm, growth-favouring temperatures coupled with high relative humidity, however, will set the stage for mildew growth.\n They can also inhibit mildew growth by lowering indoor temperatures. [<a href='https://en.wikipedia.org/wiki/Mildew' > https://en.wikipedia.org/wiki/Mildew </a>,<a href='https://www.britannica.com/science/mildew'>https://www.britannica.com/science/mildew </a>,<a href='https://www.goldeagle.com/tips-tools/mold-vs-mildew-whats-difference/'> https://www.goldeagle.com/tips-tools/mold-vs-mildew-whats-difference/ </a>])";
        }





    }

    public class tuple
    {
        public string crop;
        public string disease;
        public string med1;
        public string med2;
        public string med3;

        public tuple(string crop, string disease, string medicine1, string medicine2, string medicine3)
        {
            this.crop = crop;
            this.disease = disease;
            this.med1 = medicine1;
            this.med2 = medicine2;
            this.med3 = medicine3;
        }


    }



}
