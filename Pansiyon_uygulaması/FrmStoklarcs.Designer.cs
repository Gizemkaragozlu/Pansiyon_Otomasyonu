
namespace Pansiyon_uygulaması
{
    partial class FrmStoklarcs
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Gıdalar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Icecek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cerezler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrpMutfak = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtCerezler = new System.Windows.Forms.TextBox();
            this.TxtIcecekler = new System.Windows.Forms.TextBox();
            this.TxtGidalar = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GrpFaturalar = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Elektrik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Su = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doğalgaz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnKaydet2 = new System.Windows.Forms.Button();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.TxtDgaz = new System.Windows.Forms.TextBox();
            this.GrpMutfak.SuspendLayout();
            this.GrpFaturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gıdalar,
            this.Icecek,
            this.Cerezler});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 382);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(617, 219);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Gıdalar
            // 
            this.Gıdalar.Text = "Gıdalar";
            this.Gıdalar.Width = 174;
            // 
            // Icecek
            // 
            this.Icecek.Text = "Icecek";
            this.Icecek.Width = 151;
            // 
            // Cerezler
            // 
            this.Cerezler.Text = "Cerezler";
            this.Cerezler.Width = 202;
            // 
            // GrpMutfak
            // 
            this.GrpMutfak.Controls.Add(this.BtnKaydet);
            this.GrpMutfak.Controls.Add(this.TxtCerezler);
            this.GrpMutfak.Controls.Add(this.listView1);
            this.GrpMutfak.Controls.Add(this.TxtIcecekler);
            this.GrpMutfak.Controls.Add(this.TxtGidalar);
            this.GrpMutfak.Controls.Add(this.labelControl3);
            this.GrpMutfak.Controls.Add(this.labelControl2);
            this.GrpMutfak.Controls.Add(this.labelControl1);
            this.GrpMutfak.ForeColor = System.Drawing.Color.White;
            this.GrpMutfak.Location = new System.Drawing.Point(12, 12);
            this.GrpMutfak.Name = "GrpMutfak";
            this.GrpMutfak.Size = new System.Drawing.Size(629, 607);
            this.GrpMutfak.TabIndex = 15;
            this.GrpMutfak.TabStop = false;
            this.GrpMutfak.Text = "Mutfak";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(233, 228);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(176, 41);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // TxtCerezler
            // 
            this.TxtCerezler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCerezler.Location = new System.Drawing.Point(210, 173);
            this.TxtCerezler.Name = "TxtCerezler";
            this.TxtCerezler.Size = new System.Drawing.Size(221, 34);
            this.TxtCerezler.TabIndex = 12;
            // 
            // TxtIcecekler
            // 
            this.TxtIcecekler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIcecekler.Location = new System.Drawing.Point(210, 111);
            this.TxtIcecekler.Name = "TxtIcecekler";
            this.TxtIcecekler.Size = new System.Drawing.Size(221, 34);
            this.TxtIcecekler.TabIndex = 11;
            // 
            // TxtGidalar
            // 
            this.TxtGidalar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGidalar.Location = new System.Drawing.Point(210, 57);
            this.TxtGidalar.Name = "TxtGidalar";
            this.TxtGidalar.Size = new System.Drawing.Size(221, 34);
            this.TxtGidalar.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(113, 183);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 19);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Çerezler :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(79, 115);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "İcecek Tutarı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(91, 61);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Gıda Tutarı :";
            // 
            // GrpFaturalar
            // 
            this.GrpFaturalar.Controls.Add(this.listView2);
            this.GrpFaturalar.Controls.Add(this.labelControl6);
            this.GrpFaturalar.Controls.Add(this.labelControl4);
            this.GrpFaturalar.Controls.Add(this.BtnKaydet2);
            this.GrpFaturalar.Controls.Add(this.labelControl5);
            this.GrpFaturalar.Controls.Add(this.TxtElektrik);
            this.GrpFaturalar.Controls.Add(this.TxtSu);
            this.GrpFaturalar.Controls.Add(this.TxtDgaz);
            this.GrpFaturalar.ForeColor = System.Drawing.Color.White;
            this.GrpFaturalar.Location = new System.Drawing.Point(660, 12);
            this.GrpFaturalar.Name = "GrpFaturalar";
            this.GrpFaturalar.Size = new System.Drawing.Size(629, 607);
            this.GrpFaturalar.TabIndex = 16;
            this.GrpFaturalar.TabStop = false;
            this.GrpFaturalar.Text = "Faturalar";
            this.GrpFaturalar.Enter += new System.EventHandler(this.GrpFaturalar_Enter);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Elektrik,
            this.Su,
            this.Doğalgaz});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 382);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(617, 219);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Elektrik
            // 
            this.Elektrik.Text = "Elektrik";
            this.Elektrik.Width = 179;
            // 
            // Su
            // 
            this.Su.Text = "Su";
            this.Su.Width = 152;
            // 
            // Doğalgaz
            // 
            this.Doğalgaz.Text = "Doğalgaz";
            this.Doğalgaz.Width = 202;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(153, 72);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(21);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 19);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Elektrik :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(140, 187);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 19);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Doğalgaz :";
            // 
            // BtnKaydet2
            // 
            this.BtnKaydet2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet2.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet2.Location = new System.Drawing.Point(276, 232);
            this.BtnKaydet2.Name = "BtnKaydet2";
            this.BtnKaydet2.Size = new System.Drawing.Size(176, 41);
            this.BtnKaydet2.TabIndex = 21;
            this.BtnKaydet2.Text = "Kaydet";
            this.BtnKaydet2.UseVisualStyleBackColor = true;
            this.BtnKaydet2.Click += new System.EventHandler(this.BtnKaydet2_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(187, 130);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 19);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Su :";
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtElektrik.Location = new System.Drawing.Point(253, 61);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(221, 34);
            this.TxtElektrik.TabIndex = 18;
            // 
            // TxtSu
            // 
            this.TxtSu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSu.Location = new System.Drawing.Point(253, 115);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(221, 34);
            this.TxtSu.TabIndex = 19;
            // 
            // TxtDgaz
            // 
            this.TxtDgaz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDgaz.Location = new System.Drawing.Point(253, 177);
            this.TxtDgaz.Name = "TxtDgaz";
            this.TxtDgaz.Size = new System.Drawing.Size(221, 34);
            this.TxtDgaz.TabIndex = 20;
            // 
            // FrmStoklarcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1363, 640);
            this.Controls.Add(this.GrpFaturalar);
            this.Controls.Add(this.GrpMutfak);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklarcs";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.FrmStoklarcs_Load);
            this.GrpMutfak.ResumeLayout(false);
            this.GrpMutfak.PerformLayout();
            this.GrpFaturalar.ResumeLayout(false);
            this.GrpFaturalar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Gıdalar;
        private System.Windows.Forms.ColumnHeader Icecek;
        private System.Windows.Forms.ColumnHeader Cerezler;
        private System.Windows.Forms.GroupBox GrpMutfak;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtCerezler;
        private System.Windows.Forms.TextBox TxtIcecekler;
        private System.Windows.Forms.TextBox TxtGidalar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox GrpFaturalar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button BtnKaydet2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox TxtDgaz;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Elektrik;
        private System.Windows.Forms.ColumnHeader Su;
        private System.Windows.Forms.ColumnHeader Doğalgaz;
    }
}