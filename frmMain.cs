using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Stitching;


////////////////////////////////////////////////////////////////////////////////////////////

namespace stitching2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////////
       
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOpenfilesD = new OpenFileDialog();

            ofdOpenfilesD.CheckFileExists = true;
            ofdOpenfilesD.Multiselect = true;

            if(ofdOpenfilesD .ShowDialog()!=DialogResult.OK||ofdOpenfilesD.FileName=="")
            {
                MessageBox.Show("Can not read image");

            }
            else if(ofdOpenfilesD.ShowDialog()==DialogResult.OK)
            {
                dgvSourceImage.Rows.Clear();
               

                Image<Bgr, Byte>[] originalImagesU = new Image<Bgr, byte>[ofdOpenfilesD.FileNames.Length];

                for (int i=0;i<originalImagesU.Length;i++)
                {
                    originalImagesU[i] = new Image<Bgr, byte>(ofdOpenfilesD.FileNames[i]);

                    using (Image<Bgr, byte> firstImage = originalImagesU[i].Resize(200, 200, Inter.Cubic, true)) 

                    {
                        DataGridViewRow row = dgvSourceImage.Rows[dgvSourceImage.Rows.Add()];
                        row.Cells["fileNameColumn"].Value = ofdOpenfilesD.FileNames[i];
                        row.Cells["samplePictureColumn"].Value = firstImage.ToBitmap();
                        row.Height = 200;

                        
                    }
                }
                try
                {
                    using (Stitcher stiching = new Stitcher(false))
                    {
                        using (VectorOfMat matVector = new VectorOfMat())
                        {
                            Mat finalImageN = new Mat();
                            matVector.Push(originalImagesU);
                            stiching.Stitch(matVector, finalImageN);
                            ibFinalImage.Image = finalImageN;

                        }
                    }
                }
                finally
                {
                    foreach(Image<Bgr,Byte> image in originalImagesU)
                    {
                        image.Dispose();
                    }
                }
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////


        private void btSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog svdImages = new SaveFileDialog();

            svdImages.Title = "save images.";

            svdImages.ShowDialog();
            /*
            if(svdImages.FileName!="")
            {
                FileStream fsSave = (FileStream)svdImages.OpenFile();

                this.btSaveImage.Image.Save(fsSave, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            */
        }
        ////////////////////////////////////////////////////////////////////////////////////////////

    }
}
