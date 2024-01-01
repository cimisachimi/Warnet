using Percobaan2.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Percobaan2.Controller;

namespace Percobaan2.View
{
    public partial class CrudOperator : Form
    {
        public delegate void CreateUpdateEventHandler(Operator @operator);


        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private OperatorController controllerOperator;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk menyimpan objek pelanggan
        private Operator @operator;


        public CrudOperator()
        {
            InitializeComponent();
        }

        public CrudOperator(string title, OperatorController operatorController)
            : this()
        {
            this.Text = title;
            this.controllerOperator = operatorController;
        }

        public CrudOperator(string title, Operator obj, OperatorController controllerOperator)
    : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controllerOperator = controllerOperator;

            isNewData = false; // set status edit data
            @operator = obj; // set objek operator yang akan diedit

            // untuk edit data, tampilkan data lama
            txtID_Operator.Text = @operator.ID_Operator;
            txtNamaOperator.Text = @operator.Nama;
            txtAlamatOperator.Text = @operator.Alamat;
            txtUmurOperator.Text = @operator.Umur.ToString();
            cmbShift.SelectedIndex = 0;
            txtUsernameOperator.Text = @operator.Username;
            txtPasswordOperator.Text = @operator.Password;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKirimOperator_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek pelanggan
            if (isNewData) @operator = new Operator();

            // set nilai property objek pelanggan yg diambil dari TextBox
            @operator.ID_Operator = txtID_Operator.Text;
            @operator.Nama = txtNamaOperator.Text;
            @operator.Alamat = txtAlamatOperator.Text;

            switch (cmbShift.SelectedIndex)
            {
                case 0: // penambahan

                    break;

                case 1: // pengurangan

                    break;

                case 2: // perkalian

                    break;
            }

                    if (int.TryParse(txtUmurOperator.Text, out int umur))
            {
                @operator.Umur = umur;
            }
            else
            {
                MessageBox.Show("Umur harus berupa angka!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            @operator.Username = txtUsernameOperator.Text;
            @operator.Password = txtPasswordOperator.Text;
            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controllerOperator.Create(@operator);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(@operator); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtID_Operator.Clear();
                    txtNamaOperator.Clear();
                    txtAlamatOperator.Clear();
                    txtUmurOperator.Clear();
                    cmbShift.SelectedIndex = 0;
                    txtUsernameOperator.Clear();
                    txtPasswordOperator.Clear();

                    txtID_Operator.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controllerOperator.Update(@operator);

                if (result > 0)
                {
                    OnUpdate(@operator); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnCancelOperator_Click(object sender, EventArgs e)
        {
            // tutup form entry pelanggan
            this.Close();
        }
    }
}
