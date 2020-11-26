using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Solidare.Core
{
    public class Database
    {
        private static readonly SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);

        public static D Get<D>(Operation get, Mapper<D> mapper, Parameters parameters = null)
        {
            D result = default(D);

            PerformAtDatabase(() => {
                var command = GetCommand(get, parameters);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = mapper.Map(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue));
                    }
                }
            });
            
            return result;
        }

        public static List<D> GetAll<D>(Operation get, Mapper<D> mapper, Parameters parameters = null)
        {
            List<D> result = new List<D>();

            PerformAtDatabase(() => {
                var command = GetCommand(get, parameters);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result.Add(mapper.Map(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue)));
                    }
                }
            });

            return result;
        }

        public static void Update(Operation update, Parameters parameters)
        {
            PerformAtDatabase(() => { GetCommand(update, parameters).ExecuteNonQuery(); });
        }

        private static void PerformAtDatabase(Action action)
        {
            connection.Open();

            action();

            connection.Close();
        }

        private static SqlCommand GetCommand(Operation operation, Parameters parameters = null)
        {
            var command = new SqlCommand(operation.Query, connection);

            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters.List)
                {
                    command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
                }
            }

            return command;
        }

        public interface Operation
        {
            string Query { get; }
        }

        public interface Parameters
        {
            Dictionary<string, object> List { get; }
        }

        public interface Mapper<D>
        {
            D Map(Dictionary<string, object> reader);
        }
    }
}
