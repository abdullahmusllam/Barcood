using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using System.Data.SqlClient;
using System.Data;

namespace Barcode
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Barcode\Barcode\Database1.mdf;Integrated Security=True");
        public DataTable dt_items = new DataTable();

        private void loadItems()
        {
            try
            {
                dt_items.Clear();
                var com = new SqlCommand("SELECT * FROM Items", con);
                con.Open();
                dt_items.Load(com.ExecuteReader());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBarcodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(BarcodeTxt.Text)) // نتأكد إنه مربع النص مش فاضي
                {
                    //MessageBox.Show("Text Box is Null!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var barcode = new BarcodeWriter();
                switch (TypeBarcodeComo.SelectedIndex) // اختيار نوع الباركود الماخوذ من الكموبوكس
                {
                    case 0:
                        barcode.Format = BarcodeFormat.CODE_128;                 
                        break;
                    case 1:
                        barcode.Format = BarcodeFormat.AZTEC;
                        break;
                    case 2:
                        barcode.Format = BarcodeFormat.CODABAR;
                        break;
                    case 3:
                        barcode.Format = BarcodeFormat.DATA_MATRIX;
                        break;
                    case 4:
                        barcode.Format = BarcodeFormat.QR_CODE;
                        break;
                    
                }
                pictureBox1.Image = barcode.Write(BarcodeTxt.Text); // يجمع الباركود في الصورة
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TypeBarcodeComo.Items.Clear();
                
                TypeBarcodeComo.Items.Add("CODE_128");// إضافة الانواع حق الباركود للكموبوكس
                TypeBarcodeComo.Items.Add("AZTEC");
                TypeBarcodeComo.Items.Add("CODABAR");
                TypeBarcodeComo.Items.Add("DATA_MATRIX");
                TypeBarcodeComo.Items.Add("QR_CODE");

                TypeBarcodeComo.SelectedIndex = 0;

                loadItems();

                dataGridView1.DataSource = dt_items;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TypeBarcodeComo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateBarcodeBtn_Click(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            BarcodeTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NameClassTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PrcieClassTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CreateBarcodeBtn_Click(sender, e);
        }
    }
}
