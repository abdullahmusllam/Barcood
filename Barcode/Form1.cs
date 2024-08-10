using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;

namespace Barcode
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(BarcodeTxt.Text)) // نتأكد إنه مربع النص مش فاضي
                {
                    MessageBox.Show("Text Box is Null!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var barcode = new BarcodeWriter();
                barcode.Format = BarcodeFormat.CODE_128; // نوع من أنواع الباركود
                barcode.Format = BarcodeFormat.All_1D;
                barcode.Format = BarcodeFormat.AZTEC;
                barcode.Format = BarcodeFormat.CODABAR;
                barcode.Format = BarcodeFormat.DATA_MATRIX;
                barcode.Format = BarcodeFormat.EAN_13;
                barcode.Format = BarcodeFormat.QR_CODE;
                barcode.Format = BarcodeFormat.UPC_A;

                pictureBox1.Image = barcode.Write(BarcodeTxt.Text); // يجمع الباركود في الصورة
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
