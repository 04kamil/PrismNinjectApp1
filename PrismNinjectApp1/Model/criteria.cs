using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismNinjectApp1.Model
{
    class Criteria
    {

        private double Value { get; set; }
        private Alternative Basic { get; set; }
        private Alternative Target { get; set; }

        public Criteria(double value_, Alternative Basic_, Alternative Target_)
        {
            this.Value = value_;
            this.Basic = Basic_;
            this.Target = Target_;
        }
    }
}
