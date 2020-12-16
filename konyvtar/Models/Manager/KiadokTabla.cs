using System;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using konyvtar.Models.Records;

namespace konyvtar.Models.Manager
{
    class KiadokTabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=ORA_S1340;Password=EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }

        public List<Kiadok> Select()
        {
            List<Kiadok> records = new List<Kiadok>();

            OracleConnection oc =  GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT * FROM kiadok" 
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Kiadok kiado = new Kiadok();
                kiado.Id = reader["id"].ToString();
                kiado.Nev = reader["nev"].ToString();

                records.Add(kiado);
            }
            oc.Close();

            return records;
        }


        public int Delete(Kiadok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM kiadok WHERE id = :id"
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

        public void Update(Kiadok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "spUpdate_kiadok"
            };

            OracleParameter IdParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Id
            };
            command.Parameters.Add(IdParameter);

            OracleParameter NevParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_nev",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Nev
            };
            command.Parameters.Add(NevParameter);

            command.Connection = oc;
            command.Transaction = ot;

            try
            {
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            oc.Close();
        }

        public void Insert(Kiadok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_kiadok"
            };

            OracleParameter IdParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Id
            };
            command.Parameters.Add(IdParameter);

            OracleParameter NevParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_nev",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Nev
            };
            command.Parameters.Add(NevParameter);

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
            finally
            {
                oc.Close();
            }


        }


        public void CheckKiado_id(string id)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_kiado_id"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter IdParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = id

            };
            command.Parameters.Add(IdParameter);

            command.Connection = oc;
            

         /*   try
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
