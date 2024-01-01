using Percobaan2.Controller;
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

namespace Percobaan2.View
{
    public partial class buatTransaksi : Form
    {

        public delegate void CreateUpdateEventHandler(TransaksiWarnet transaksi);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private TransaksiWarnetController transaksiWarnetController;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk menyimpan objek pelanggan
        private TransaksiWarnet transaksi;

        public buatTransaksi()
        {
            InitializeComponent();
        }

        public buatTransaksi(string title, TransaksiWarnetController transaksiWarnetController)
    : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.transaksiWarnetController = transaksiWarnetController;
        }


        private void btnKirimTransaksi_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek transaksi
            if (isNewData) transaksi = new TransaksiWarnet();

            // set nilai property objek transaksi yg diambil dari TextBox
            transaksi.ID_Transaksi = txt_IDTransaksi.Text;
            transaksi.Username = txtUsername.Text;
            transaksi.Tanggal = DateTime.Parse(txtDateTransaksi.Text); // Assuming txtTanggal is a TextBox for date input
            transaksi.Waktu = int.Parse(txtWaktuBilling.Text);
            transaksi.Harga = int.Parse(txtHarga.Text);
            transaksi.Operator = txtOperator.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = transaksiWarnetController.Create(transaksi);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(transaksi); // panggil event OnCreate


                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD

                if (result > 0)
                {
                    OnUpdate(transaksi); // panggil event OnUpdate
                    this.Close();
                }
            }

        }
    }
}
