namespace ImageDetectionProject
{
    partial class MainProgram
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rchtxtCenter = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbCommand = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnObj = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnStdAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rchtxtAddress = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtCell = new System.Windows.Forms.MaskedTextBox();
            this.msktxtDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchtxtCenter
            // 
            this.rchtxtCenter.Location = new System.Drawing.Point(4, 4);
            this.rchtxtCenter.Name = "rchtxtCenter";
            this.rchtxtCenter.Size = new System.Drawing.Size(370, 125);
            this.rchtxtCenter.TabIndex = 0;
            this.rchtxtCenter.Text = "";
            this.rchtxtCenter.TextChanged += new System.EventHandler(this.rchtxtCenter_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbCommand);
            this.panel5.Controls.Add(this.rchtxtCenter);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(263, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(898, 199);
            this.panel5.TabIndex = 13;
            // 
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.Location = new System.Drawing.Point(380, 7);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(95, 17);
            this.lbCommand.TabIndex = 0;
            this.lbCommand.Text = "Please Wait...";
            this.lbCommand.TextChanged += new System.EventHandler(this.lbCommand_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(263, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(898, 178);
            this.panel4.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(898, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(263, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 143);
            this.panel3.TabIndex = 11;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(653, 16);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(100, 23);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnObj
            // 
            this.btnObj.Location = new System.Drawing.Point(393, 16);
            this.btnObj.Name = "btnObj";
            this.btnObj.Size = new System.Drawing.Size(124, 26);
            this.btnObj.TabIndex = 0;
            this.btnObj.Text = "Object Detection";
            this.btnObj.UseVisualStyleBackColor = true;
            this.btnObj.Click += new System.EventHandler(this.btnObj_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(523, 16);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(124, 26);
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "Image";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCam
            // 
            this.btnCam.Location = new System.Drawing.Point(133, 16);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(124, 26);
            this.btnCam.TabIndex = 0;
            this.btnCam.Text = "Camera Feel";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // btnStdAdd
            // 
            this.btnStdAdd.Location = new System.Drawing.Point(3, 16);
            this.btnStdAdd.Name = "btnStdAdd";
            this.btnStdAdd.Size = new System.Drawing.Size(124, 26);
            this.btnStdAdd.TabIndex = 0;
            this.btnStdAdd.Text = "Student Add";
            this.btnStdAdd.UseVisualStyleBackColor = true;
            this.btnStdAdd.Click += new System.EventHandler(this.btnStdAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnListen);
            this.panel2.Controls.Add(this.btnObj);
            this.panel2.Controls.Add(this.btnSpeak);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnCam);
            this.panel2.Controls.Add(this.btnStdAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(263, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 55);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rchtxtAddress);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.msktxtCell);
            this.panel1.Controls.Add(this.msktxtDate);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 575);
            this.panel1.TabIndex = 9;
            // 
            // rchtxtAddress
            // 
            this.rchtxtAddress.Location = new System.Drawing.Point(114, 310);
            this.rchtxtAddress.Name = "rchtxtAddress";
            this.rchtxtAddress.Size = new System.Drawing.Size(131, 96);
            this.rchtxtAddress.TabIndex = 4;
            this.rchtxtAddress.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 44);
            this.label10.TabIndex = 0;
            this.label10.Text = "STUDENT REGISTRATION\r\n            FORM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "STUDENT\'S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // msktxtCell
            // 
            this.msktxtCell.Location = new System.Drawing.Point(114, 281);
            this.msktxtCell.Mask = "(999) 000-0000";
            this.msktxtCell.Name = "msktxtCell";
            this.msktxtCell.Size = new System.Drawing.Size(131, 22);
            this.msktxtCell.TabIndex = 3;
            this.msktxtCell.BackColorChanged += new System.EventHandler(this.msktxtCell_BackColorChanged);
            // 
            // msktxtDate
            // 
            this.msktxtDate.Location = new System.Drawing.Point(114, 412);
            this.msktxtDate.Mask = "00/00/0000";
            this.msktxtDate.Name = "msktxtDate";
            this.msktxtDate.Size = new System.Drawing.Size(131, 22);
            this.msktxtDate.TabIndex = 3;
            this.msktxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.cmbStatus.Location = new System.Drawing.Point(114, 441);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(131, 24);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.BackColorChanged += new System.EventHandler(this.cmbStatus_BackColorChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(114, 224);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(131, 22);
            this.txtNumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Entrance Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(114, 195);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(131, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cell Phone:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(114, 252);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(131, 22);
            this.txtDepartment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 575);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainProgram";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtCenter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnObj;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnStdAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchtxtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtCell;
        private System.Windows.Forms.MaskedTextBox msktxtDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}

