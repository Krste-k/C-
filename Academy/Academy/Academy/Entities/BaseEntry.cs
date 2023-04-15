using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public abstract class BaseEntry
    {
        public int Id { get; set; }

        public abstract void PrintInfo();
    }
}
