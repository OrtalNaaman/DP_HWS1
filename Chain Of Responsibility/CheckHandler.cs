using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    public abstract class CheckHandler
    {
        protected CheckHandler next;

        public CheckHandler SetNext(CheckHandler next)
        {
            this.next = next;
            return this.next;
        }

        public abstract void HandleRequest(Car carToFix);
    }

}
