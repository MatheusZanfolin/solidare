using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace SolidareWeb.Feature.Login.Operations
{
    public class SignIn : Operation
    {
        public string Query => "SELECT * FROM Doadores WHERE usuario = @usuario AND senha = @senha";
    }

    public class SignInParameters : Parameters
    {
        private string Username;
        private string Password;

        public SignInParameters(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@usuario", Username },
            { "@senha", Password }
        };
    }

    class SignInMapper : Mapper<Donor>
    {
        public Donor Map(Dictionary<string, object> reader)
        {
            return new Donor
            (
                (int) reader["id"],
                (string) reader["nome"],
                (string) reader["email"],
                (string) reader["cpf"],
                (string) reader["telefone"],
                (string) reader["celular"],
                (string) reader["username"],
                (string) reader["senha"],
                (int) reader["id_cidade"]
            );
        }
    }
}