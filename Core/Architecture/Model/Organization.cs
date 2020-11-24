using System.Collections.Generic;

namespace Solidare.Core.Architecture.Model
{
    public class Organization
    {
   
        public int ID { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public string Address { get; private set; }

        public string CNPJ { get; private set; }

        public string Website { get; private set; }

        public string App { get; private set; }

        public string Logo { get; private set; }

        public int CityID { get; private set; }

        public Organization(int id, string name, string email, string phone, string address, string cnpj, string website, string app, string logo, int cityID)
        {
            ID = id;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            CNPJ = cnpj;
            Website = website;
            App = app;
            Logo = logo;
            CityID = cityID;
        }

    }
}