using System;

namespace csharp
{
    class BackstageItem : InheritItem
    {
        public const int MaxQuality = 50;
        public BackstageItem(InheritItem item)
            : base(item)
        {
        }

        public BackstageItem(string name, int sellin, int quality)
            : base(name, sellin, quality)
        {
        }

        public BackstageItem()
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
