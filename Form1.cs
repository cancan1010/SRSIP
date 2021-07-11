using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Speech.Recognition;

namespace ImageDetectionProject
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }
        public void StudentList()
        {
            var students = db.TBLSTUDENT.ToList();
            dataGridView1.DataSource = students;
        }
        db_StudentsEntities1 db = new db_StudentsEntities1();
        void enabled()
        {
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtNumber.Enabled = false;
            txtDepartment.Enabled = false;
            msktxtCell.Enabled = false;
            rchtxtAddress.Enabled = false;
            msktxtDate.Enabled = false;
            cmbStatus.Enabled = false;

        }
        void colorMethod()
        {
            txtName.BackColor = Color.White;
            txtSurname.BackColor = Color.White;
            txtNumber.BackColor = Color.White;
            txtDepartment.BackColor = Color.White;
            msktxtCell.BackColor = Color.White;
            rchtxtAddress.BackColor = Color.White;
            msktxtDate.BackColor = Color.White;
            cmbStatus.BackColor = Color.White;
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            SpVoice sound = new SpVoice();
            sound.Speak(rchtxtCenter.Text);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            try
            {
                btnSpeak.Text = "Please Speak";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                rchtxtCenter.Text = res.Text;
            }
            catch (Exception)
            {
                btnSpeak.Text = "Error Try Again";
            }
        }

        private void btnStdAdd_Click(object sender, EventArgs e)
        {
            TBLSTUDENT t = new TBLSTUDENT();
            t.NAME = txtName.Text;
            t.SURNAME = txtSurname.Text;
            t.NUMBER = Int32.Parse(txtNumber.Text);
            t.DEPARTMENT = txtDepartment.Text;
            t.CELLPHONE = msktxtCell.Text;
            t.ADDRESS = rchtxtAddress.Text;
            t.ENTRANCE_DATE = DateTime.Parse(msktxtDate.Text);
            t.STATUS = cmbStatus.Text;
            db.TBLSTUDENT.Add(t);
            db.SaveChanges();
            lbCommand.Text = "Student saved in Database";
        }


        private void rchtxtCenter_TextChanged(object sender, EventArgs e)
        {
            if(txtName.BackColor==Color.Yellow && txtName.Enabled == true)
            {
                txtName.Text = rchtxtCenter.Text;
                enabled();
                colorMethod();
            }
            if (txtSurname.BackColor == Color.Yellow && txtSurname.Enabled == true)
            {
                txtSurname.Text = rchtxtCenter.Text;
                enabled();
                colorMethod();
            }
            if (txtNumber.BackColor == Color.Yellow && txtNumber.Enabled == true)
            {
                txtNumber.Text = rchtxtCenter.Text;
                enabled();
                colorMethod();
            }
            if (txtDepartment.BackColor == Color.Yellow && txtDepartment.Enabled == true)
            {
                txtDepartment.Text = rchtxtCenter.Text;
                enabled();
                colorMethod();
            }
            if (msktxtCell.BackColor == Color.Yellow && msktxtCell.Enabled == true)
            {
                msktxtCell.Text = rchtxtCenter.Text;
                enabled();
                colorMethod();
            }
            if (rchtxtAddress.BackColor == Color.Yellow && rchtxtAddress.Enabled == true)
            {
                rchtxtAddress.Text = rchtxtCenter.Text;
                enabled();
                colorMethod();
            }
            if (msktxtDate.BackColor == Color.Yellow && msktxtDate.Enabled == true)
            {
                enabled();
                colorMethod();
            }
            if (cmbStatus.BackColor == Color.Yellow && cmbStatus.Enabled == true)
            {
                cmbStatus.Text = rchtxtCenter.Text;
                enabled();
                colorMethod();
            }
            if (rchtxtCenter.Text=="List of students"|| rchtxtCenter.Text == "Students list")
            {
                StudentList();
            }
            if(rchtxtCenter.Text=="Add"|| rchtxtCenter.Text == "Add to"|| rchtxtCenter.Text == "Add the")
            {
                TBLSTUDENT t = new TBLSTUDENT();
                t.NAME = txtName.Text;
                t.SURNAME = txtSurname.Text;
                t.NUMBER = Int32.Parse(txtNumber.Text);
                t.DEPARTMENT = txtDepartment.Text;
                t.CELLPHONE =msktxtCell.Text;
                t.ADDRESS = rchtxtAddress.Text;
                t.ENTRANCE_DATE = DateTime.Parse(msktxtDate.Text);
                t.STATUS = cmbStatus.Text;
                db.TBLSTUDENT.Add(t);
                db.SaveChanges();
                lbCommand.Text = "Student saved in Database";
            }
            if (rchtxtCenter.Text == "Students name" || rchtxtCenter.Text == "First row" || rchtxtCenter.Text == "Name")
            {
                txtName.Focus();
                txtName.BackColor = Color.Yellow;
                txtName.Enabled = true;
                
            }
            if (rchtxtCenter.Text == "Students surname" || rchtxtCenter.Text == "Second row" || rchtxtCenter.Text == "Surname")
            {
                txtSurname.Focus();
                txtSurname.BackColor = Color.Yellow;
                txtSurname.Enabled = true;
            }
            if (rchtxtCenter.Text == "Students number" || rchtxtCenter.Text == "Third row" || rchtxtCenter.Text == "Number")
            {
                txtNumber.Focus();
                txtNumber.BackColor = Color.Yellow;
                txtNumber.Enabled = true;
            }
            if (rchtxtCenter.Text == "Students department" || rchtxtCenter.Text == "Fourth row" || rchtxtCenter.Text == "Department")
            {
                txtDepartment.Focus();
                txtDepartment.BackColor = Color.Yellow;
                txtDepartment.Enabled = true;
            }
            if (rchtxtCenter.Text == "Students cell phone" || rchtxtCenter.Text == "Fifth row" || rchtxtCenter.Text == "Cell phone")
            {
                msktxtCell.Focus();
                msktxtCell.BackColor = Color.Yellow;
                msktxtCell.Enabled = true;
            }
            if (rchtxtCenter.Text == "Students address" || rchtxtCenter.Text == "Sixth row" || rchtxtCenter.Text == "Address")
            {
                rchtxtAddress.Focus();
                rchtxtAddress.BackColor = Color.Yellow;
                rchtxtAddress.Enabled = true;
            }
            if (rchtxtCenter.Text == "Students entrance date" || rchtxtCenter.Text == "Seventh row" || rchtxtCenter.Text == "Entrance")
            {
                msktxtDate.Focus();
                msktxtDate.BackColor = Color.Yellow;
                msktxtDate.Enabled = true;
            }
            if (rchtxtCenter.Text == "Students status" || rchtxtCenter.Text == "Eighth row" || rchtxtCenter.Text == "Status")
            {
                cmbStatus.Focus();
                cmbStatus.BackColor = Color.Yellow;
                cmbStatus.Enabled = true;
            }
            if (rchtxtCenter.Text == "Exit" || rchtxtCenter.Text == "Quit" || rchtxtCenter.Text == "Exit application")
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            enabled();
            colorMethod();
        }

        private void msktxtCell_BackColorChanged(object sender, EventArgs e)
        {
            if (msktxtDate.BackColor == Color.Yellow)
            {
                msktxtDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }

        private void cmbStatus_BackColorChanged(object sender, EventArgs e)
        {
            if (cmbStatus.BackColor == Color.Yellow)
            {
                cmbStatus.Text = "Active";
            }
        }

        private void lbCommand_TextChanged(object sender, EventArgs e)
        {
            SpVoice sound = new SpVoice();
            sound.Speak(lbCommand.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            try
            {
                btnSpeak.Text = "Please Speak";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                rchtxtCenter.Text = res.Text;
            }
            catch (Exception)
            {
                btnSpeak.Text = "Error Try Again";
            }
        }

        private void btnObj_Click(object sender, EventArgs e)
        {
            Forms.FrmObjDet fr = new Forms.FrmObjDet();
            fr.Show();
            this.Hide();
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            Forms.FrmAforge fr2 = new Forms.FrmAforge();
            fr2.Show();
            this.Hide();
        }
    }
}
