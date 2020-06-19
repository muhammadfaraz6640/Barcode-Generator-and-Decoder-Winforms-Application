using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BarcodeReadWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Encodebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Encode_txt = EncodeTxt.Text;
                BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                BarcodePic.Image = writer.Write(Encode_txt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Decodebtn_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader();
                var result_decode = reader.Decode((Bitmap)BarcodePic.Image);
                if (result_decode != null)
                {
                    DecodeTxt.Text = result_decode.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
