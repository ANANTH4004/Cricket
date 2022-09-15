using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
      public  Player()
        {

        }
       public Player(int PlayerId, string PlayerName , int PlayerAge)
        {
            this.PlayerId = PlayerId;
            this.PlayerName = PlayerName;
            this.PlayerAge = PlayerAge;
        }
    }
}
