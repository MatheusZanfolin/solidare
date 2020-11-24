namespace Solidare.Core.Architecture.Model
{
    public class Administrator
    {
        public int ID { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public int OrganizationID { get; private set; }

        public Administrator(int id, string username, string password, int organizationID)
        {
            ID = id;
            Username = username;
            Password = password;
            OrganizationID = organizationID;
        }
    }
}
