using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string TeamName { get; set; }

        public List<personModel> Teammember { get; set; } =  new List<personModel>();
        

       
        /// <summary>
        /// this is optional constraction
        /// </summary>
        public TeamModel() {

            Teammember = new List<personModel>();
        }
    }
}
