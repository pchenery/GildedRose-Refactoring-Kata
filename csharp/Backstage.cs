using System;

namespace csharp
{
    class BackstageItem : InheritItem
    {
        public const int MaxQuality = 50;
        //public BackstageItem(InheritItem item)
        //    : base(item)
        //{
        //}

        //public BackstageItem(string name, int sellin, int quality)
        //    : base(name, sellin, quality)
        //{
        //}

        public BackstageItem()
        {
        }

        public override void UpdateQuality()
        {
            if (SellIn == 0)
            {
                Quality = 0;
            }
            else if (SellIn < 11 && Quality < MaxQuality)
            {
                Quality = Quality + 2;
            }
            else if (SellIn < 6 && Quality < MaxQuality)
            {
                Quality = Math.Min(Quality + 3, MaxQuality);
            }
            else
            {
                Quality++;
            }
        }
    }
}
