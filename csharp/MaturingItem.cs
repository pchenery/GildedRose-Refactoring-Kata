namespace csharp
{
    class MaturingItem : InheritItem
    {

        public MaturingItem(InheritItem item)
            : base(item)
        {
        }

        public MaturingItem(string name, int sellin, int quality)
            : base(name, sellin, quality)
        {
        }

        public MaturingItem()
        {
        }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }
    }
}
