using System;

namespace csharp
{
    class BackstageItem : StandardItem
    {
        public BackstageItem(StandardItem item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            base.UpdateQuality();
            if (SellIn < 11 && Quality < MaxQuality)
            {
                Quality++;
            }
            else if (SellIn < 6 && Quality < MaxQuality)
            {
                Quality = Math.Min(Quality + 2, MaxQuality);
            }
            else if (SellIn == 0)
            {
                Quality = 0;
            }
        }
    }
}
