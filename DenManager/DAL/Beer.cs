using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DenManager.DAL
{
    public class Beer
    {
        [Range(0.0, 25.0)]
        public decimal Bottle { get; set; }
    }
}