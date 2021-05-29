

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

                        

                        Label1.Text = diagnosis;
                        string infoprog = Server.MapPath("./summary_link.py");
                        if (diagnosis.ToLower().Trim().Contains("health") == false)
                        {
                            System.Diagnostics.Debug.WriteLine(diagnosis.ToLower().Trim());

                            string summary_info = EntryPoint.get_info_python(infoprog, diagnosis.Trim());
                            System.Diagnostics.Debug.WriteLine(summary_info);

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
            treat[2] = new tuple("Apple", "Cedar_apple_rust", "Immunox", "", "");
            treat[3] = new tuple("Grapes", "Black_rot", "captan", "myclobutanil", "");
            treat[4] = new tuple("Grapes", "Esca_(Black_Measles)", "Removed and burned", "", "");
            treat[5] = new tuple("Grapes", "Leaf_blight_(Isariopsis_Leaf_Spot)", "Bonide®️ Sulfur Plant Fungicide", "Organocide®️ Plant Doctor", "");
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

            String treatment = "vvv";
            String planttype2 = DropDownList1.SelectedItem.Text;
            String diagnosis1 = Label1.Text;
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
            return "Mildew";
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
            //  return output[0];
            return "(A leaf miner is any one of numerous species of insects in which the larval stage lives in, and eats, the leaf tissue of plants.\n Like woodboring beetles, leaf miners are protected from many predators and plant defenses by feeding within the tissues of the leaves, selectively eating only the layers that have the least amount of cellulose.\n When attacking Quercus robur (English oak), they also selectively feed on tissues containing lower levels of tannin, a deterrent chemical produced in great abundance by the tree.The pattern of the feeding tunnel and the layer of the leaf being mined is often diagnostic of the insect responsible, sometimes even to species level.\n The mine often contains frass, or droppings, and the pattern of frass deposition, mine shape, and host plant identity are useful to determine the species and instar of the leaf miner.\n Spraying the infected plants with spinosad, an organic insecticide, can control some leaf miners.\n The leaf and stem mines of British flies and other insects.\n Includes illustrated keys for identification of mines by host-plant genus and detailed descriptions of over 900 species along with their distribution in Great Britain and Northern Ireland and elsewhere. [<a href='https://www.planetnatural.com/pest-problem-solver/houseplant-pests/leafminer-control/'> Link1 </a>, https://www.gardeningknowhow.com/plant-problems/pests/insects/leaf-miner-control.htm, https://www.gardeningknowhow.com/plant-problems/pests/insects/june-bug-beetles.htm, https://www.gardeningknowhow.com/special/organic/what-are-organic-pesticides.htm, https://www.gardeningknowhow.com/plant-problems/pests/insects/beneficial-insects.htm, https://en.wikipedia.org/wiki/Leaf_miner, https://www.pestnet.org/fact_sheets/leafminers_110.htm, https://extension.umn.edu/yard-and-garden-insects/leafminers, https://www.epicgardening.com/leaf-miner/, https://www2.ipm.ucanr.edu/agriculture/lettuce/Leafminers/])";
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
