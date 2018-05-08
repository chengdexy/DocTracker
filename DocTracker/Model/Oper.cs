using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTracker.Model
{
    /// <summary>
    /// Circulation operation 流转操作
    /// </summary>
    class Oper
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int DocID { get; set; }
        public Doc Doc { get; set; }
    }
}
