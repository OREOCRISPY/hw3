using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Record
    {
        private String Date;
        private string Description;
        private string Category;
        private double Amount;

        public String rDate {
            set { Date = value; }
            get { return Date; }
        }

        public String rDes{
            set { Description = value; }
            get { return Description; }
        }

        public String rCategory
        {
            set { Category = value; }
            get { return Category; }
        }

        public double rAmount
        {
            set { Amount = value; }
            get { return Amount; }
        }
    }
}
