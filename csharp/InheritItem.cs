namespace csharp
{
    public class InheritItem : Item
    {
        //private InheritItem item;

        public InheritItem()
        {
        }

        public InheritItem(string name, int sellin, int quality)
        {
            Name = name;
            SellIn = sellin;
            Quality = quality;
        }

        public InheritItem(Item item)
        {
            Name = item.Name;
            SellIn = item.SellIn;
            Quality = item.Quality;
        }

        //public InheritItem(InheritItem item)
        //{
        //    this.item = item;
        //}

        public virtual void UpdateQuality()
        {
        }

        public void UpdateSellIn()
        {
            SellIn--;
        }
    }
}
