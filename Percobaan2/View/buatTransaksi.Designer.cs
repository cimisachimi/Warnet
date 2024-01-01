namespace Percobaan2.View
{
    partial class buatTransaksi
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
            txt_IDTransaksi = new TextBox();
            txtUsername = new TextBox();
            txtWaktuBilling = new TextBox();
            txtHarga = new TextBox();
            txtOperator = new TextBox();
            txtDateTransaksi = new DateTimePicker();
            lbl1 = new Label();
            lbl = new Label();
            label3 = new Label();
            fdsf = new Label();
            label5 = new Label();
            label6 = new Label();
            btnKirimTransaksi = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // txt_IDTransaksi
            // 
            txt_IDTransaksi.Location = new Point(121, 70);
            txt_IDTransaksi.Name = "txt_IDTransaksi";
            txt_IDTransaksi.Size = new Size(100, 23);
            txt_IDTransaksi.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(121, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtWaktuBilling
            // 
            txtWaktuBilling.Location = new Point(121, 201);
            txtWaktuBilling.Name = "txtWaktuBilling";
            txtWaktuBilling.Size = new Size(176, 23);
            txtWaktuBilling.TabIndex = 2;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(121, 242);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(100, 23);
            txtHarga.TabIndex = 4;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(121, 282);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(100, 23);
            txtOperator.TabIndex = 5;
            // 
            // txtDateTransaksi
            // 
            txtDateTransaksi.Location = new Point(121, 157);
            txtDateTransaksi.Name = "txtDateTransaksi";
            txtDateTransaksi.Size = new Size(200, 23);
            txtDateTransaksi.TabIndex = 6;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(29, 78);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(68, 15);
            lbl1.TabIndex = 7;
            lbl1.Text = "ID Transaksi";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(29, 118);
            lbl.Name = "lbl";
            lbl.Size = new Size(60, 15);
            lbl.TabIndex = 8;
            lbl.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 163);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Tanggal";
            // 
            // fdsf
            // 
            fdsf.AutoSize = true;
            fdsf.Location = new Point(29, 209);
            fdsf.Name = "fdsf";
            fdsf.Size = new Size(77, 15);
            fdsf.TabIndex = 10;
            fdsf.Text = "Waktu billing";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 250);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Harga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 285);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Operator";
            // 
            // btnKirimTransaksi
            // 
            btnKirimTransaksi.Location = new Point(121, 339);
            btnKirimTransaksi.Name = "btnKirimTransaksi";
            btnKirimTransaksi.Size = new Size(75, 23);
            btnKirimTransaksi.TabIndex = 13;
            btnKirimTransaksi.Text = "Kirim";
            btnKirimTransaksi.UseVisualStyleBackColor = true;
            btnKirimTransaksi.Click += btnKirimTransaksi_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(222, 339);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 14;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // buatTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(btnBatal);
            Controls.Add(btnKirimTransaksi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(fdsf);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(lbl1);
            Controls.Add(txtDateTransaksi);
            Controls.Add(txtOperator);
            Controls.Add(txtHarga);
            Controls.Add(txtWaktuBilling);
            Controls.Add(txtUsername);
            Controls.Add(txt_IDTransaksi);
            Name = "buatTransaksi";
            Text = "buatTransaksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_IDTransaksi;
        private TextBox txtUsername;
        private TextBox txtWaktuBilling;
        private TextBox txtHarga;
        private TextBox txtOperator;
        private DateTimePicker txtDateTransaksi;
        private Label lbl1;
        private Label lbl;
        private Label label3;
        private Label fdsf;
        private Label label5;
        private Label label6;
        private Button btnKirimTransaksi;
        private Button btnBatal;
    }
}