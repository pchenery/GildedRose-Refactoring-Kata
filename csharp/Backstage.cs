using System;

namespace csharp
{
    class BackstageItem : InheritItem
    {
        private const int MaxQuality = 50;
        //public BackstageItem(InheritItem item)
        //    : base(item)
        //{
        //}

        public BackstageItem()
        {
        }

        public override void UpdateQuality()
        {
            if (SellIn <= 0)
            {
                Quality = 0;
            }
            else if (SellIn < 6 && Quality < MaxQuality)
            {
                Quality = Math.Min(Quality + 3, MaxQuality);
            }
            else if (SellIn < 11 && Quality < MaxQuality)
            {
                Quality = Math.Min(Quality + 2, MaxQuality);
            }
            else
            {
                Quality = Math.Min(++Quality, MaxQuality);
            }
        }
    }
}
