using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public class PersonInf
    {

        public int Id = 1548;
        public string FirstName = "Gary";
        public string LastName = "Galva";

        public string NameCompleted { get { return this.FirstName + " " + this.LastName; } }

       


    }
}
