namespace Solidare.Core.Architecture.Model
{
    public class ItemCategory
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public ItemCategory(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}