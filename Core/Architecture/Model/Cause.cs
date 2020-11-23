namespace Solidare.Core.Architecture.Model
{
    public class Cause
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public Cause(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}