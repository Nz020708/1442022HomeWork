using System;
using System.Collections.Generic;
using System.Text;

namespace _4142022HomeWork
{
   public  class Boutique
    {
        public int Id { get; set; }
        public List<Sales> Sales { get; set; }
        public Sales dress { get; set; }
        public double TotalSale { get; set; }
    }
}
