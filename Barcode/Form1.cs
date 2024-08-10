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
                if (string.IsNullOrWhiteSpace(BarcodeTxt.Text))
                {
                    var barcode = new BarcodeWriter();
                    barcode.Format = BarcodeFormat.CODE_128;
                }
            }catch(Exception ex)
            {

            }
        }
    }
}
