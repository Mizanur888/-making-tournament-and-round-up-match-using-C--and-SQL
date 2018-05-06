using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
   public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string Placename { get; set; }
        public decimal PriceAmount { get; set; }
        public double PricePercentage { get; set; }

        public PrizeModel() {

        }
        public PrizeModel(string pNumber, string pname, string pamount, string Ppercentage) {

            Placename = pname;
            int placenumberValue = 0;
            int.TryParse(pNumber, out placenumberValue);
            this.PlaceNumber = placenumberValue;
            decimal prizeAmountN = 0;
            decimal.TryParse(pamount, out prizeAmountN);
            this.PriceAmount = prizeAmountN;
            double prizePer = 0;
            double.TryParse(Ppercentage,out prizePer);
            this.PricePercentage = prizePer;

        }
    }
}
