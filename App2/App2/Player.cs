using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Player
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Rolle { get; set; }
        /*  public string OnElect { get; set; }
          public string CountElect { get; set; }
          public int Nights { get; set; }
          public int Days { get; set; }
          public int Fouls { get; set; }
          public bool IsChecked { get; set; }
          public bool CheckRezult { get; set; }
          public bool IsKilledByM { get; set; }
          public bool IsDisqual { get; set; }
          public bool IsKilledByS { get; set; }*/
       
        public Player(int id, string nickName, string rolle)
        {
            this.Id = id;
            this.NickName = nickName;
            this.Rolle = rolle;
        }
        public Player()
        { }
        
    }

    
}
