namespace csharp
{
    public class InheritItem : Item
    {
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

         public virtual void UpdateQuality()
        {
        }

        public virtual void UpdateSellIn()
        {
            SellIn--;
        }
    }
}
