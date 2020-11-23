namespace Solidare.Core.Architecture.Model
{
    public class ItemUnit
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public ItemUnit(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}