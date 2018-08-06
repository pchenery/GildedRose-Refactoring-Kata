using System;

namespace csharp
{
    class ConjuredItem : InheritItem
    {
        public const int MaxQuality = 50;

        //public ConjuredItem(InheritItem item)
        //    : base(item)
        //{
        //}

        //public ConjuredItem(string name, int sellin, int quality)
        //    : base(name, sellin, quality)
        //{
        //}

        public ConjuredItem()
        {
        }

        public override void UpdateQuality()
        {
            Quality = Math.Max(Quality - 2, 0);
        }
    }
}
