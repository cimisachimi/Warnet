﻿namespace Percobaan2.View
{
    partial class IsiAkun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvwAkun = new ListView();
            txtCariAkun = new TextBox();
            btnCariAkun = new Button();
            btnBaruAkun = new Button();
            btnEditAkun = new Button();
            btnHapusAkun = new Button();
            btnTambahBilling = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvwAkun
            // 
            lvwAkun.ForeColor = Color.Black;
            lvwAkun.Location = new Point(235, 48);
            lvwAkun.Name = "lvwAkun";
            lvwAkun.Size = new Size(809, 468);
            lvwAkun.TabIndex = 0;
            lvwAkun.UseCompatibleStateImageBehavior = false;
            // 
            // txtCariAkun
            // 
            txtCariAkun.Location = new Point(48, 77);
            txtCariAkun.Name = "txtCariAkun";
            txtCariAkun.Size = new Size(121, 23);
            txtCariAkun.TabIndex = 1;
            // 
            // btnCariAkun
            // 
            btnCariAkun.Location = new Point(89, 106);
            btnCariAkun.Name = "btnCariAkun";
            btnCariAkun.Size = new Size(80, 23);
            btnCariAkun.TabIndex = 3;
            btnCariAkun.Text = "Cari";
            btnCariAkun.UseVisualStyleBackColor = true;
            btnCariAkun.Click += btnCariAkun_Click;
            // 
            // btnBaruAkun
            // 
            btnBaruAkun.Location = new Point(235, 19);
            btnBaruAkun.Name = "btnBaruAkun";
            btnBaruAkun.Size = new Size(75, 23);
            btnBaruAkun.TabIndex = 4;
            btnBaruAkun.Text = "Buat Akun";
            btnBaruAkun.UseVisualStyleBackColor = true;
            btnBaruAkun.Click += btnBaruAkun_Click;
            // 
            // btnEditAkun
            // 
            btnEditAkun.Location = new Point(423, 19);
            btnEditAkun.Name = "btnEditAkun";
            btnEditAkun.Size = new Size(105, 23);
            btnEditAkun.TabIndex = 5;
            btnEditAkun.Text = "Edit";
            btnEditAkun.UseVisualStyleBackColor = true;
            btnEditAkun.Click += btnEditAkun_Click;
            // 
            // btnHapusAkun
            // 
            btnHapusAkun.Location = new Point(534, 19);
            btnHapusAkun.Name = "btnHapusAkun";
            btnHapusAkun.Size = new Size(88, 23);
            btnHapusAkun.TabIndex = 5;
            btnHapusAkun.Text = "Hapus";
            btnHapusAkun.UseVisualStyleBackColor = true;
            btnHapusAkun.Click += btnHapusAkun_Click;
            // 
            // btnTambahBilling
            // 
            btnTambahBilling.Location = new Point(316, 19);
            btnTambahBilling.Name = "btnTambahBilling";
            btnTambahBilling.Size = new Size(101, 23);
            btnTambahBilling.TabIndex = 6;
            btnTambahBilling.Text = "Tambah Billing";
            btnTambahBilling.UseVisualStyleBackColor = true;
            btnTambahBilling.Click += btnTambahBilling_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(969, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 59);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 8;
            label1.Text = "Cari Berdasarkan Nama";
            // 
            // IsiAkun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnTambahBilling);
            Controls.Add(btnHapusAkun);
            Controls.Add(btnEditAkun);
            Controls.Add(btnBaruAkun);
            Controls.Add(btnCariAkun);
            Controls.Add(txtCariAkun);
            Controls.Add(lvwAkun);
            Name = "IsiAkun";
            Size = new Size(1066, 569);
            Load += IsiAkun_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvwAkun;
        private TextBox txtCariAkun;
        private Button btnCariAkun;
        private Button btnBaruAkun;
        private Button btnEditAkun;
        private Button btnHapusAkun;
        private Button btnTambahBilling;
        private Button btnRefresh;
        private Label label1;
    }
}
