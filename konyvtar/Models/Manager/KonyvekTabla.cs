using System;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using konyvtar.Models.Records;

namespace konyvtar.Models.Manager
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

            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT * FROM books"
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Konyvek konyv = new Konyvek();
                konyv.Id = reader["id"].ToString();
                konyv.Raktari_szam = reader["raktari_szam"].ToString();
                konyv.Cim = reader["cim"].ToString();
             // konyv.Mufaj = (Mufaj)reader["mufaj"];
                konyv.Mufaj = (Mufaj)Enum.Parse(typeof(Mufaj), reader["mufaj"].ToString());
                konyv.Kiado_id = reader["kiado_id"].ToString();
                konyv.Kiadas_eve = reader["kiadas_eve"].ToString();

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
                CommandText = "DELETE FROM books WHERE id = :id"
            };

            OracleParameter IdParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Id
            };
            command.Parameters.Add(IdParameter);

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

        public void Update(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "spUpdate_books"
            };

            /*OracleParameter IdParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Id
            };
            command.Parameters.Add(IdParameter);
            */
            OracleParameter Raktari_szamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_raktari_szam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Raktari_szam
            };
            command.Parameters.Add(Raktari_szamParameter);

            OracleParameter Kiado_idParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_kiado_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kiado_id
            };
            command.Parameters.Add(Kiado_idParameter);

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

            command.Connection = oc;
            command.Transaction = ot;

            try
            {
                command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            oc.Close();
        }

        public void Insert(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_books"
            };

           /* OracleParameter IdParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Id
            };
            command.Parameters.Add(IdParameter);
           */
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
                ParameterName = "p_kiado_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kiado_id
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


            command.Connection = oc;
            command.Transaction = ot;
            
            try
            {
                int szam = command.ExecuteNonQuery();

                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            finally
            {
                oc.Close();
            }


        }


        public void CheckKonyv_id(string id)
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

            OracleParameter IdParameter= new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = id

            };

            command.Parameters.Add(IdParameter);
            command.Connection = oc;
        /*    try
            {
                int successful = int.Parse(correct.Value.ToString());

                return successful != 0;
            }
            catch (Exception)
            {
                return false;
            }
        */

        }

        public void CheckRaktari_szam(string raktari_szam)
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
/*
            try
            {
                int successful = int.Parse(correct.Value.ToString());

                return successful != 0;
            }
            catch (Exception)
            {
                return false;
            }
*/

        }


    }
}
