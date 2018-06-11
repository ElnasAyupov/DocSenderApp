using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsSenderApp.Models
{
    public class Rank
    {
        public Rank()
        {
            RankId = Guid.NewGuid().ToString();
        }

        public string RankId { get; set; }
        public string Name { get; set; }
    }
}
