using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Conversiones
    {
        public int Id_Currency{ get; set; }
        public string From_Currency { get; set; }
        public string To_Currency { get; set; }
        public double Rate { get; set; }
    }
}
