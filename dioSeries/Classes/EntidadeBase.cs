using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dioSeries
{
   public abstract class EntidadeBase
    {

        protected int id;

        public int Id { get => id; set => id = value; }
    }
}
