using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class StandardItem : InheritItem
    {
        public const int MaxQuality = 50;

        //public StandardItem(InheritItem item)
        //    : base(item)
        //{
        //}

        public StandardItem(string name, int sellin, int quality)
            : base(name, sellin, quality)
        {
        }

        public StandardItem()
        {
        }

        private StandardItem Item { get; set; }

        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }
        }
    }
}
