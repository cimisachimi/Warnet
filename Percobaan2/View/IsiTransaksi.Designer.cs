namespace Percobaan2.View
{
    partial class IsiTransaksi
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
            dateStart = new DateTimePicker();
            lvwTransaksi = new ListView();
            dateFinish = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            lblPendapatan = new Label();
            btnTransaksi = new Button();
            SuspendLayout();
            // 
            // dateStart
            // 
            dateStart.Location = new Point(86, 47);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(200, 23);
            dateStart.TabIndex = 0;
            // 
            // lvwTransaksi
            // 
            lvwTransaksi.Location = new Point(28, 76);
            lvwTransaksi.Name = "lvwTransaksi";
            lvwTransaksi.Size = new Size(897, 402);
            lvwTransaksi.TabIndex = 1;
            lvwTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // dateFinish
            // 
            dateFinish.Location = new Point(349, 47);
            dateFinish.Name = "dateFinish";
            dateFinish.Size = new Size(200, 23);
            dateFinish.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "sampai :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 53);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "dari :";
            // 
            // button1
            // 
            button1.Location = new Point(573, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "tampilkan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(682, 512);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 5;
            label3.Text = "Total Pendapatan :";
            // 
            // lblPendapatan
            // 
            lblPendapatan.AutoSize = true;
            lblPendapatan.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPendapatan.Location = new Point(859, 512);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(23, 28);
            lblPendapatan.TabIndex = 5;
            lblPendapatan.Text = "0";
            // 
            // btnTransaksi
            // 
            btnTransaksi.Location = new Point(850, 45);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(75, 23);
            btnTransaksi.TabIndex = 6;
            btnTransaksi.Text = "Buat";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // IsiTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTransaksi);
            Controls.Add(lblPendapatan);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvwTransaksi);
            Controls.Add(dateFinish);
            Controls.Add(dateStart);
            Name = "IsiTransaksi";
            Size = new Size(1013, 655);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateStart;
        private ListView lvwTransaksi;
        private DateTimePicker dateFinish;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label lblPendapatan;
        private Button btnTransaksi;
    }
}
