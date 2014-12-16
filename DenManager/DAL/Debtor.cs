using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DenManager.DAL
{
    public class Debtor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Debt{ get; set; }
    }
}
