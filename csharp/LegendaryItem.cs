using System.Net.Http.Headers;

namespace csharp
{
    class LegendaryItem : StandardItem
    {
        public LegendaryItem(StandardItem item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            Quality = 80;
        }
    }
}
