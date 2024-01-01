using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using System.Collections.Generic;

namespace Percobaan2.Controller
{
    public class OperatorController
    {
        private OperatorRepository _repository;

        public List<Operator> ReadAll()
        {
            List<Operator> operators = new List<Operator>();

            using (DbContext context = new DbContext())
            {
                _repository = new OperatorRepository(context);
                operators = _repository.ReadAll();
            }

            return operators;
        }

        // You can add additional methods for Create, Edit, Delete, etc., as needed.
        // Example:

        public int Create(Operator operatorObject)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new OperatorRepository(context);
                return _repository.Create(operatorObject);
            }
        }
        public bool IsValidOperator(string userName, string password)
        {
            // cek username yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // cek password yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidOperator = false;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new OperatorRepository(context);

                // panggil method IsValidOperator class repository untuk memeriksa keberadaan operator
                isValidOperator = _repository.IsValidOperator(userName, password);
            }

            if (!isValidOperator)
            {
                MessageBox.Show("Username atau password operator salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
        public int Update(Operator operatorObject)
        {
            int result = 0;

            // Check if ID_Operator is empty or null
            if (string.IsNullOrEmpty(operatorObject.ID_Operator))
            {
                MessageBox.Show("ID Operator harus diisi !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Check if Nama is empty or null
            if (string.IsNullOrEmpty(operatorObject.Nama))
            {
                MessageBox.Show("Nama Operator harus diisi !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Create a context using a using block
            using (DbContext context = new DbContext())
            {
                // Create a repository object
                _repository = new OperatorRepository(context); // Assuming you have an OperatorRepository class

                // Call the Update method of the repository to update data
                result = _repository.Update(operatorObject);
            }

            // Display appropriate messages based on the result
            if (result > 0)
            {
                MessageBox.Show("Data operator berhasil diupdate!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data operator gagal diupdate !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }



    }
}
