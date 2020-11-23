namespace Solidare.Core.Architecture.Model
{
    public class City
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public State State { get; private set; }

        public City(int id, string name, State state)
        {
            ID = id;
            Name = name;
            State = state;
        }
    }
}
