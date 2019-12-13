using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
    }
}
