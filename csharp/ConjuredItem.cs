using System;

namespace csharp
{
    class ConjuredItem : InheritItem
    {
        private const int MaxQuality = 50;

        //public ConjuredItem(InheritItem item)
        //    : base(item)
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
