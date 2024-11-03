using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Model.Entities
{
    public class LeaderBoard
    {
        public int Id { get; set; }
        public string Player { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Score { get; set; } = 0;
    }
}
