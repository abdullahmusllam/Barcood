namespace Barcode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TypeBarcodeComo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OpenBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.PrintBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CreateBarcodeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PrcieClassTxt = new System.Windows.Forms.TextBox();
            this.NameClassTxt = new System.Windows.Forms.TextBox();
            this.nameClassLap = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBarcodeLap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.TypeBarcodeComo);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.OpenBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.CreateBarcodeBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PrcieClassTxt);
            this.panel1.Controls.Add(this.NameClassTxt);
            this.panel1.Controls.Add(this.nameClassLap);
            this.panel1.Controls.Add(this.BarcodeTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.typeBarcodeLap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 646);
            this.panel1.TabIndex = 0;
            // 
            // TypeBarcodeComo
            // 
            this.TypeBarcodeComo.FormattingEnabled = true;
            this.TypeBarcodeComo.Location = new System.Drawing.Point(16, 43);
            this.TypeBarcodeComo.Name = "TypeBarcodeComo";
            this.TypeBarcodeComo.Size = new System.Drawing.Size(257, 30);
            this.TypeBarcodeComo.TabIndex = 13;
            this.TypeBarcodeComo.SelectedIndexChanged += new System.EventHandler(this.TypeBarcodeComo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 380);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(292, 266);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OpenBtn.ImageOptions.Image")));
            this.OpenBtn.Location = new System.Drawing.Point(191, 344);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(81, 30);
            this.OpenBtn.TabIndex = 11;
            this.OpenBtn.Text = "Open";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.SaveBtn.Appearance.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.Appearance.Options.UseBackColor = true;
            this.SaveBtn.Appearance.Options.UseFont = true;
            this.SaveBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.ImageOptions.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(102, 344);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(81, 30);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.PrintBtn.Appearance.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.PrintBtn.Appearance.Options.UseBackColor = true;
            this.PrintBtn.Appearance.Options.UseFont = true;
            this.PrintBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.ImageOptions.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(12, 344);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(81, 30);
            this.PrintBtn.TabIndex = 9;
            this.PrintBtn.Text = "Print";
            // 
            // CreateBarcodeBtn
            // 
            this.CreateBarcodeBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.CreateBarcodeBtn.Appearance.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBarcodeBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CreateBarcodeBtn.Appearance.Options.UseBackColor = true;
            this.CreateBarcodeBtn.Appearance.Options.UseFont = true;
            this.CreateBarcodeBtn.Appearance.Options.UseForeColor = true;
            this.CreateBarcodeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreateBarcodeBtn.ImageOptions.Image")));
            this.CreateBarcodeBtn.Location = new System.Drawing.Point(12, 308);
            this.CreateBarcodeBtn.Name = "CreateBarcodeBtn";
            this.CreateBarcodeBtn.Size = new System.Drawing.Size(261, 30);
            this.CreateBarcodeBtn.TabIndex = 8;
            this.CreateBarcodeBtn.Text = "Create Barcode";
            this.CreateBarcodeBtn.Click += new System.EventHandler(this.CreateBarcodeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price Of Class";
            // 
            // PrcieClassTxt
            // 
            this.PrcieClassTxt.Location = new System.Drawing.Point(12, 260);
            this.PrcieClassTxt.Name = "PrcieClassTxt";
            this.PrcieClassTxt.Size = new System.Drawing.Size(261, 30);
            this.PrcieClassTxt.TabIndex = 6;
            this.PrcieClassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameClassTxt
            // 
            this.NameClassTxt.Location = new System.Drawing.Point(12, 186);
            this.NameClassTxt.Name = "NameClassTxt";
            this.NameClassTxt.Size = new System.Drawing.Size(261, 30);
            this.NameClassTxt.TabIndex = 5;
            this.NameClassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameClassLap
            // 
            this.nameClassLap.AutoSize = true;
            this.nameClassLap.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameClassLap.ForeColor = System.Drawing.Color.White;
            this.nameClassLap.Location = new System.Drawing.Point(12, 159);
            this.nameClassLap.Name = "nameClassLap";
            this.nameClassLap.Size = new System.Drawing.Size(110, 24);
            this.nameClassLap.TabIndex = 4;
            this.nameClassLap.Text = "Name Of Class";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Location = new System.Drawing.Point(12, 114);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(261, 30);
            this.BarcodeTxt.TabIndex = 3;
            this.BarcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            // 
            // typeBarcodeLap
            // 
            this.typeBarcodeLap.AutoSize = true;
            this.typeBarcodeLap.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBarcodeLap.ForeColor = System.Drawing.Color.White;
            this.typeBarcodeLap.Location = new System.Drawing.Point(12, 16);
            this.typeBarcodeLap.Name = "typeBarcodeLap";
            this.typeBarcodeLap.Size = new System.Drawing.Size(105, 24);
            this.typeBarcodeLap.TabIndex = 0;
            this.typeBarcodeLap.Text = "Type Barcode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(292, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.LargeImage")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton CreateBarcodeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrcieClassTxt;
        private System.Windows.Forms.TextBox NameClassTxt;
        private System.Windows.Forms.Label nameClassLap;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typeBarcodeLap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton PrintBtn;
        private DevExpress.XtraEditors.SimpleButton OpenBtn;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TypeBarcodeComo;
    }
}

