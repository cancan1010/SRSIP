using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace ImageDetectionProject.Forms
{
    public partial class FrmFaceRecog : Form
    {
        public FrmFaceRecog()
        {
            Control.CheckForIllegalCrossThreadCalls = false;//iş parçacığı oluşturma ve denetleme
            InitializeComponent();
        }

        private void FrmFaceRecog_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await Task.Run(() => //işlerin belirli düzeyde çalışmasını sağlar
            {

            });
        }
        BusinessRecognition recognition = new BusinessRecognition(@"Faces", "face.xml");
        
    }
}
