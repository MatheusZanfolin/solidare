namespace Solidare.Core.Architecture.Model
{
    public class State
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public State(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
