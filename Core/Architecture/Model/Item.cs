namespace Solidare.Core.Architecture.Model
{
    public class Item
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public int CategoryID { get; private set; }

        public int UnitID { get; private set; }

        public Item(int id, string name, int categoryID, int unitID)
        {
            ID = id;
            Name = name;
            CategoryID = categoryID;
            UnitID = unitID;
        }
    }
}