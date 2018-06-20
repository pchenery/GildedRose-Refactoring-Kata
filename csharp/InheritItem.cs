using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class InheritItem : Item
    {
        public virtual void UpdateQuality()
        {
            Quality++;
        }
    }
}
