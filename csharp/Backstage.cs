using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Backstage : InheritItem
    {
        public override void UpdateQuality()
        {
            if (SellIn > 10 && Quality < 50)
            {
                Quality++;
            }
            else if (SellIn <= 10)
            {
                Quality = Quality + 2;
            }
            else if (SellIn <= 5)
            {
                Quality = Quality + 5;
            }
            else if (SellIn == 0)
            {
                Quality = 0;
            }
        }
    }
}
