﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Productos
    {
        public int Id_Sku { get; set; }
        public double Ammount{ get; set; }
        public string Currency{ get; set; }
    }
}
