using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class StandardItem : InheritItem
    {
        private const int MaxQuality = 50;

        //public StandardItem(InheritItem item)
        //    : base(item)
        //{
        //}

        public StandardItem()
        {
        }

        private StandardItem Item { get; set; }

        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality -= SellIn <= 0 ? 2 : 1;
            }
        }
    }
}
