using System;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using etterem.Models.Records;

namespace etterem.Models.Manager
{
    class KonyvekTabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=ORA_S1340;Password=EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }

        public List<Konyvek> Select()
        {
            List<Konyvek> records = new List<Konyvek>();

            OracleConnection oc = new OracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT ko.konyv_id, ko.raktari_szam, ki.nev, ko.mufaj, ko.cim, ko.kiadas_eve FROM " +
                " konyvek ko INNER JOIN kiadok ki ON ki.id = ko.kiado_id"
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Konyvek konyv = new Konyvek();
                konyv.Konyv_id = reader["konyv_id"].ToString();
                konyv.Raktari_szam = reader["raktari_szam"].ToString();
                konyv.Cim = reader["cim"].ToString();
                konyv.Mufaj = (Mufaj)reader["mufaj"];
                konyv.Kiado = reader["nev"].ToString();

                records.Add(konyv);
            }
            oc.Close();

            return records;
        }


        public int Delete(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM konyvek WHERE konyv_id = :konyv_id"
            };

            OracleParameter Konyv_idParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":konyv_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Konyv_id
            };
            command.Parameters.Add(Konyv_idParameter);

            command.Connection = oc;
            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            oc.Close();

            return affectedRows;
        }


        public int Insert(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_konyvek"
            };

            OracleParameter Konyv_idParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_konyv_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Konyv_id
            };
            command.Parameters.Add(Konyv_idParameter);

            OracleParameter Raktari_szamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_raktari_szam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Raktari_szam
            };
            command.Parameters.Add(Raktari_szamParameter);

            OracleParameter KiadoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_kiado",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kiado
            };
            command.Parameters.Add(KiadoParameter);

            OracleParameter CimParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_cim",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Cim
            };
            command.Parameters.Add(CimParameter);

            OracleParameter MufajParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_mufaj",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Mufaj
            };
            command.Parameters.Add(MufajParameter);

            OracleParameter Kiadas_eveParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_kiadas_eve",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kiadas_eve
            };
            command.Parameters.Add(Kiadas_eveParameter);



            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };

            command.Connection = oc;
            command.Transaction = ot;

            oc.Close();

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {
                ot.Rollback();
                return 0;
            }


        }


        public bool CheckKonyv_id(int konyv_id)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_konyv_id"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter Konyv_idParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_konyv_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = konyv_id

            };
            command.Parameters.Add(Konyv_idParameter);

            command.Connection = oc;

            try
            {
                int successful = int.Parse(correct.Value.ToString());

                return successful != 0;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public bool CheckRaktari_szam(string raktari_szam)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_raktari_szam"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter Raktari_szamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_raktari_szam",
                Direction = System.Data.ParameterDirection.Input,
                Value = raktari_szam

            };
            command.Parameters.Add(Raktari_szamParameter);

            command.Connection = oc;

            try
            {
                int successful = int.Parse(correct.Value.ToString());

                return successful != 0;
            }
            catch (Exception)
            {
                return false;
            }


        }


    }
}
