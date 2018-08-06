using System.Net.Http.Headers;

namespace csharp
{
    class LegendaryItem : InheritItem
    {
        public const int MaxQuality = 80;

        //public LegendaryItem(InheritItem item)
        //    : base(item)
        //{
        //}

        //public LegendaryItem(string name, int sellin, int quality)
        //    : base(name, sellin, quality)
        //{
        //}

        public LegendaryItem()
        {
        }

        public override void UpdateQuality()
        {
            Quality = MaxQuality;
        }
    }
}
