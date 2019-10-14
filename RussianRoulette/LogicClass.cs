using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public class LogicClass
    {
        int Bullet;
         public void LoadLogic() //loading the gun
        {
            Bullet = 6;
        }
        
        public int SpinLogic()//spinning th echambers of gun
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7); //setting a range
            return Bullet; 
        }
        int chances = 4; // chances to shoot on head
        public int ShootLogic()
        {            //
            if (Bullet == 1)
            {
                // the user is dead!
                MessageBox.Show("You are dead, do you want to play again?","Game Over!");
                Application.Restart();
            }
            else
            {
                chances--;
                Bullet--;
                //if chances of shooting at your head is zero, tell him you survived unless tell him keep playing
                if (chances == 0)
                {
                    MessageBox.Show("You win!!! Congrats! Do you want to play again?", "Game Over!");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Try your luck.. Fingers crossed");
                }
            }
            return chances;
        }
        int ChancesAway = 2;
        public int ShootAwayLogic()
        {
            if (Bullet == 1)
            {
                //tell the user you died!
                MessageBox.Show("You survive");
            }
            else
            {                
                ChancesAway--;
                Bullet--;
                //if chances are zero tell him you are dead else tell him keep playing
                if(ChancesAway == 0)
                {
                    MessageBox.Show("You have lost all chances of survival, do you want to play again?","Game Over");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("All the best!! Last chance to try your luck");
                }
            }
            
            return ChancesAway;
        }

    }
}
