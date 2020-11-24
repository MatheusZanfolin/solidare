namespace Solidare.Core.Architecture.Model
{
    public class Donor
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string CPF { get; private set; }

        public string Phone { get; private set; }

        public string Cellphone { get; private set; }

        public string Username { get; private set; }

        public int CityID { get; private set; }

        public Donor(int id, string name, string email, string cpf, string phone, string cellphone, string username, int cityID)
        {
            ID = id;
            Name = name;
            Email = email;
            CPF = cpf;
            Phone = phone;
            Cellphone = cellphone;
            Username = username;
            CityID = cityID;
        }
    }
}
