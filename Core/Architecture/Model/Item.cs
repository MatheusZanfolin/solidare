namespace Solidare.Core.Architecture.Model
{
    public class Item
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public string Image { get; private set; }

        public ItemCategory Category { get; private set; }

        public ItemUnit Unit { get; private set; }

        public Item(int id, string name, string image, ItemCategory category, ItemUnit unit)
        {
            ID = id;
            Name = name;
            Image = image;
            Category = category;
            Unit = unit;
        }
    }
}