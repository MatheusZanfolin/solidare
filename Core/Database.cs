using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Solidare.Core
{
    public class Database
    {
        private readonly SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);

        public List<D> Get<D>(Operation get, Mapper<D> mapper, Parameters parameters = null)
        {
            var result = new List<D>();

            PerformAtDatabase(() => {
                var command = GetCommand(get, parameters);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(mapper.Map(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue)));
                    }
                }
            });
            
            return result;
        }

        public void Insert(Operation insert)
        {
            PerformAtDatabase(() => { GetCommand(insert).ExecuteNonQuery(); });
        }

        public void Update(Operation update, Parameters parameters)
        {
            PerformAtDatabase(() => { GetCommand(update, parameters).ExecuteNonQuery(); });
        }

        public void Delete(Operation update, Parameters parameters)
        {
            PerformAtDatabase(() => { GetCommand(update, parameters).ExecuteNonQuery(); });
        }

        private void PerformAtDatabase(Action action)
        {
            connection.Open();

            action();

            connection.Close();
        }

        private SqlCommand GetCommand(Operation operation, Parameters parameters = null)
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
