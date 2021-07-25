using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coast_Busters
{
    public class Person
    {
        public int personID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string DOB { get; set; }
        public string address { get; set; }
        public int subscriptionID { get; set; }
        public int accidentsMade { get; set; }
        public int nbRentedCars { get; set; }
        public bool isCustomer { get; set; }

    }
}
