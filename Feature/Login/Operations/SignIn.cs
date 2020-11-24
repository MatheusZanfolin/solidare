using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Solidare.Core.Database;

namespace Solidare.Feature.Login.Operations
{
    class SignIn : Operation
    {
        public string Query => "SELECT * FROM Administradores WHERE usuario = @usuario and senha = @senha";
    }

    class SignInParameters : Parameters
    {
        private string User { get; }
        private string Password { get; }

        public SignInParameters(string user, string password)
        {
            User = user;
            Password = password;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@usuario", User },
            { "@senha", Password },
        };
    }

    class SignInMapper : Mapper<Administrator>
    {
        public Administrator Map(Dictionary<string, object> reader)
        {
            return new Administrator
            (
                (int) reader["id"], 
                (string) reader["usuario"],
                (string) reader["senha"],
                (int) reader["id_ong"]
            );
        }
    }
}
