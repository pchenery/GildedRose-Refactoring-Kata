namespace csharp
{
    class MaturingItem : StandardItem
    {
     
        public MaturingItem(StandardItem item)
            : base(item)
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
