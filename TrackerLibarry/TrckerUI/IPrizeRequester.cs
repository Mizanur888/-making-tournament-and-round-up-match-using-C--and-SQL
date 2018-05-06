using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibarry;

namespace TrckerUI
{
   public interface IPrizeRequester
    {
        void prizeComplete(PrizeModel model);
    }
}
