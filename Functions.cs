using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamShuffle
{
    class Functions
    {
        //Shuffles players list using Fisher-Yates method
        public static List<string> ShufflePlayers(List<string> list)
        {
            List<string> shuffled = new List<string>();
            Random r = new Random();
            int rd_int;
            
            //Choose players for team1
            while(list.Count > list.Count / 2)
            {
                rd_int = r.Next(0, list.Count);
                shuffled.Add(list[rd_int]);
                list.RemoveAt(rd_int);
            }
            //if number of all players is below 10
            while(shuffled.Count<5)
            {
                shuffled.Add("");
            }
            //other players are added to team2
            while (list.Count>0)
            {
                shuffled.Add(list[0]);
                list.RemoveAt(0);
            }
            //if number of all players is below 10
            while (shuffled.Count < 10)
            {
                shuffled.Add("");
            }
            return shuffled;
        }

        //Checks if string don't have only spaces 
        public static bool CheckIfIsEmpty(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] != ' ')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
