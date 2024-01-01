using MySql.Data.MySqlClient;
using Percobaan2.Model.Context;
using Percobaan2.Model.Entity;
using System;
using System.Collections.Generic;

namespace Percobaan2.Model.Repository
{
    public class TransaksiWarnetRepository
    {
        private MySqlConnection _conn;

        public TransaksiWarnetRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<TransaksiWarnet> ReadAll()
        {
            List<TransaksiWarnet> transaksiList = new List<TransaksiWarnet>();

            try
            {
                string sql = @"SELECT ID_Transaksi, Username, Tanggal, Harga, Waktu, Operator
                               FROM transaksi_warnet 
                               ORDER BY Tanggal";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            TransaksiWarnet transaksi = new TransaksiWarnet
                            {
                                ID_Transaksi = dtr["ID_Transaksi"].ToString(),
                                Username = dtr["Username"].ToString(),
                                Tanggal = Convert.ToDateTime(dtr["Tanggal"]),
                                Harga = Convert.ToInt32(dtr["Harga"]),
                                Waktu = Convert.ToInt32(dtr["Waktu"]),
                                Operator = dtr["Operator"].ToString()
                            };

                            transaksiList.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadAllTransaksiWarnet error: {0}", ex.Message);
            }

            return transaksiList;
        }
        public int Create(TransaksiWarnet transaksiWarnet)
        {
            int result = 0;

            string sql = @"INSERT INTO transaksiwarnet (ID_Transaksi, Username, Tanggal, Harga, Waktu, Operator)
                   VALUES (@ID_Transaksi, @Username, @Tanggal, @Harga, @Waktu, @Operator)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_Transaksi", transaksiWarnet.ID_Transaksi);
                cmd.Parameters.AddWithValue("@Username", transaksiWarnet.Username);
                cmd.Parameters.AddWithValue("@Tanggal", transaksiWarnet.Tanggal);
                cmd.Parameters.AddWithValue("@Harga", transaksiWarnet.Harga);
                cmd.Parameters.AddWithValue("@Waktu", transaksiWarnet.Waktu);
                cmd.Parameters.AddWithValue("@Operator", transaksiWarnet.Operator);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("CreateTransaksiWarnet error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<TransaksiWarnet> ReadByDateRange(DateTime startDate, DateTime endDate)
        {
            List<TransaksiWarnet> transaksiList = new List<TransaksiWarnet>();

            try
            {
                string sql = @"SELECT ID_Transaksi, Username, Tanggal, Harga, Waktu, Operator
                           FROM transaksi_warnet 
                           WHERE Tanggal BETWEEN @StartDate AND @EndDate
                           ORDER BY Tanggal";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            TransaksiWarnet transaksi = new TransaksiWarnet
                            {
                                ID_Transaksi = dtr["ID_Transaksi"].ToString(),
                                Username = dtr["Username"].ToString(),
                                Tanggal = Convert.ToDateTime(dtr["Tanggal"]),
                                Harga = Convert.ToInt32(dtr["Harga"]),
                                Waktu = Convert.ToInt32(dtr["Waktu"]),
                                Operator = dtr["Operator"].ToString()
                            };

                            transaksiList.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadByDateRange error: {0}", ex.Message);
            }

            return transaksiList;
        }
        public int CalculateTotalHarga(DateTime startDate, DateTime endDate)
        {
            int totalHarga = 0;

            try
            {
                string sql = @"SELECT SUM(Harga) AS TotalHarga
                       FROM transaksi_warnet 
                       WHERE Tanggal BETWEEN @StartDate AND @EndDate";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalHarga = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CalculateTotalHarga error: {0}", ex.Message);
            }

            return totalHarga;
        }

    }
}
