using System;

namespace csharp
{
    class ConjuredItem : StandardItem
    {

        public ConjuredItem(StandardItem item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            Quality = Math.Max(Quality - 2, MaxQuality);
        }
    }
}
