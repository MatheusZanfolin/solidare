namespace Solidare.Core.Architecture.Model
{
    public class City
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public int StateID { get; private set; }

        public City(int id, string name, int stateID)
        {
            ID = id;
            Name = name;
            StateID = stateID;
        }
    }
}
