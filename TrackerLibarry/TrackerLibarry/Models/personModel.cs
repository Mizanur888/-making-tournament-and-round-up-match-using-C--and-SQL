using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
   public class personModel
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string  EmailAddress { get; set; }
        public string phoneNumber { get; set; }
        

        public string Fullname
        {
            get { return $"{Fname} - {Lname}"; }
            
        }

        /// <summary>
        /// Defualt constructor for now it does nothing
        ///// </summary>
        //public personModel() {

        //}

        //public personModel(string Fname, string Lname, string EmailAddress, string phoneNumber) {

        //    this.Fname = Fname;
        //    this.Lname = Lname;
        //    this.EmailAddress = EmailAddress;
        //    this.phoneNumber = phoneNumber;
        //}
        ///// <summary>
        ///// copy constractor if needed
        ///// </summary>
        ///// <param name="otherModel"></param>
        //public personModel(personModel otherModel) {
        //    //TODO - implement copy constractor if needed.
        //    this.Fname = otherModel.Fname;
        //    this.Lname = otherModel.Lname;
        //    this.EmailAddress = otherModel.EmailAddress;
        //    this.phoneNumber = otherModel.phoneNumber;
        //}
    }
}
