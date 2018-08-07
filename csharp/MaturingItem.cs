using System;

namespace csharp
{
    class MaturingItem : InheritItem
    {
        private const int MaxQuality = 50;

        //public MaturingItem(InheritItem item)
        //    : base(item)
        //{
        //}

        public MaturingItem()
        {
        }

        public override void UpdateQuality()
        {
            if (SellIn <= 0)
            {
                Quality = Math.Min(Quality + 2, MaxQuality);
            }
            else if (Quality < MaxQuality)
            {
                Quality++;
            }

            //Quality = (Quality < MaxQuality) ? Quality++: Quality;
        }
    }
}
