using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiMoneyHackEmailer
{
    public class DbInfos
    {
        public List<string> suspectedPlayers { get; set; }
        public List<string> playerId { get; set; }
        public List<string> databaseId { get; set; }
        public List<string> moneyInBank { get; set; }
        public List<string> cashOnHand { get; set; }

        }
}
