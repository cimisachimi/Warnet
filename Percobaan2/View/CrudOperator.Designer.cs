namespace Percobaan2.View
{
    partial class CrudOperator
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            txtPasswordOperator = new TextBox();
            txtUsernameOperator = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            cmbShift = new ComboBox();
            label1 = new Label();
            txtUmurOperator = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            tesralse = new Label();
            txtNoTelpOperator = new TextBox();
            txtAlamatOperator = new TextBox();
            textBox3 = new TextBox();
            txtID_Operator = new TextBox();
            txtNamaOperator = new TextBox();
            label3 = new Label();
            btnKirimOperator = new Button();
            btnCancelOperator = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPasswordOperator);
            panel1.Controls.Add(txtUsernameOperator);
            panel1.Location = new Point(364, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 100);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 59);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 0;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 26);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 0;
            label5.Text = "Username : ";
            // 
            // txtPasswordOperator
            // 
            txtPasswordOperator.Location = new Point(80, 51);
            txtPasswordOperator.Name = "txtPasswordOperator";
            txtPasswordOperator.Size = new Size(145, 23);
            txtPasswordOperator.TabIndex = 3;
            txtPasswordOperator.TextChanged += textBox1_TextChanged;
            // 
            // txtUsernameOperator
            // 
            txtUsernameOperator.Location = new Point(80, 18);
            txtUsernameOperator.Name = "txtUsernameOperator";
            txtUsernameOperator.Size = new Size(145, 23);
            txtUsernameOperator.TabIndex = 3;
            txtUsernameOperator.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Detail";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbShift);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtUmurOperator);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tesralse);
            panel2.Controls.Add(txtNoTelpOperator);
            panel2.Controls.Add(txtAlamatOperator);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(txtID_Operator);
            panel2.Controls.Add(txtNamaOperator);
            panel2.Location = new Point(12, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 244);
            panel2.TabIndex = 1;
            // 
            // cmbShift
            // 
            cmbShift.FormattingEnabled = true;
            cmbShift.Items.AddRange(new object[] { "Pagi\t( 07:00-13:00)", "Siang \t( 13:00-21:00)", "Malam\t( 21:00-07:00)" });
            cmbShift.Location = new Point(108, 180);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(200, 23);
            cmbShift.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 179);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Shift :";
            // 
            // txtUmurOperator
            // 
            txtUmurOperator.Location = new Point(108, 109);
            txtUmurOperator.Name = "txtUmurOperator";
            txtUmurOperator.Size = new Size(139, 23);
            txtUmurOperator.TabIndex = 3;
            txtUmurOperator.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 146);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 0;
            label11.Text = "No. Telepon : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 117);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 0;
            label10.Text = "Umur : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 88);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 0;
            label9.Text = "Alamat : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 30);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 0;
            label4.Text = "ID Operator : ";
            // 
            // tesralse
            // 
            tesralse.AutoSize = true;
            tesralse.Location = new Point(17, 59);
            tesralse.Name = "tesralse";
            tesralse.Size = new Size(48, 15);
            tesralse.TabIndex = 0;
            tesralse.Text = "Nama : ";
            // 
            // txtNoTelpOperator
            // 
            txtNoTelpOperator.Location = new Point(108, 138);
            txtNoTelpOperator.Name = "txtNoTelpOperator";
            txtNoTelpOperator.Size = new Size(139, 23);
            txtNoTelpOperator.TabIndex = 3;
            txtNoTelpOperator.TextChanged += textBox1_TextChanged;
            // 
            // txtAlamatOperator
            // 
            txtAlamatOperator.Location = new Point(108, 80);
            txtAlamatOperator.Name = "txtAlamatOperator";
            txtAlamatOperator.Size = new Size(200, 23);
            txtAlamatOperator.TabIndex = 3;
            txtAlamatOperator.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // txtID_Operator
            // 
            txtID_Operator.Location = new Point(108, 22);
            txtID_Operator.Name = "txtID_Operator";
            txtID_Operator.Size = new Size(139, 23);
            txtID_Operator.TabIndex = 3;
            txtID_Operator.TextChanged += textBox1_TextChanged;
            // 
            // txtNamaOperator
            // 
            txtNamaOperator.Location = new Point(108, 51);
            txtNamaOperator.Name = "txtNamaOperator";
            txtNamaOperator.Size = new Size(139, 23);
            txtNamaOperator.TabIndex = 3;
            txtNamaOperator.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 16);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Akun";
            // 
            // btnKirimOperator
            // 
            btnKirimOperator.Location = new Point(368, 205);
            btnKirimOperator.Name = "btnKirimOperator";
            btnKirimOperator.Size = new Size(98, 44);
            btnKirimOperator.TabIndex = 2;
            btnKirimOperator.Text = "Oke!";
            btnKirimOperator.UseVisualStyleBackColor = true;
            // 
            // btnCancelOperator
            // 
            btnCancelOperator.Location = new Point(506, 206);
            btnCancelOperator.Name = "btnCancelOperator";
            btnCancelOperator.Size = new Size(98, 44);
            btnCancelOperator.TabIndex = 2;
            btnCancelOperator.Text = "Batal ";
            btnCancelOperator.UseVisualStyleBackColor = true;
            btnCancelOperator.Click += btnCancelOperator_Click;
            // 
            // CrudOperator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 302);
            Controls.Add(btnCancelOperator);
            Controls.Add(btnKirimOperator);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CrudOperator";
            Text = "Tambah atau Edit Akun Operator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private TextBox txtNamaOperator;
        private Label label5;
        private TextBox txtPasswordOperator;
        private TextBox txtUsernameOperator;
        private TextBox txtUmurOperator;
        private TextBox txtNoTelpOperator;
        private TextBox txtAlamatOperator;
        private TextBox textBox3;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label tesralse;
        private Button btnKirimOperator;
        private Button btnCancelOperator;
        private Label label1;
        private ComboBox cmbShift;
        private Label label4;
        private TextBox txtID_Operator;
    }
}