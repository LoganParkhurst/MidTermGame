using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game1
{
    internal class Movement
    {

        public void PlayerMovement(List<string> options, Player player)
        {
            if (player.Location == 0)
            {
                Clear();
                options.Clear();
                WriteLine("You can go to Room(s):\n");
                options.Add("1");
                options.Add("2");
                options.Add("3");
                int movementOptions = Utility.UserOptions(options);
                if (movementOptions == 0)
                {
                    options.Clear();
                    WriteLine("you walk to the first room on the left. there are two large wooden doors that are covered in dust");
                    WriteLine("Would you like to open the doors?");
                    options.Add("Yes");
                    options.Add("No");
                    int yesOrNo = Utility.UserOptions(options);
                    if (yesOrNo == 0)
                    {
                        WriteLine("With a big push the dusty doors open with an eerie creek");
                        player.Location = 1;
                    }
                    else
                    {
                        WriteLine("You decide to not open the old dust door");
                    }

                }
                else if (movementOptions == 1)
                {
                    options.Clear();
                    WriteLine("You move to the first door on the right.\nA large wooden door with a metal handle.");
                    WriteLine("Would you like to open the door?");
                    options.Add("Yes");
                    options.Add("No");
                    int yesOrNo = Utility.UserOptions(options);
                    if (yesOrNo == 0)
                    {

                        WriteLine("you pull the slowly.");
                        player.Location = 2;
                    }
                    else
                    {
                        WriteLine("You decide to not open the old dust door");
                    }
                }
                else if (movementOptions == 2)
                {
                    options.Clear();
                    WriteLine("You move to the second door on the right.\nA small wooden door you can see light streaming though.");
                    WriteLine("Would you like to open the door?");
                    options.Add("Yes");
                    options.Add("No");
                    int yesOrNo = Utility.UserOptions(options);
                    if (yesOrNo == 0)
                    {

                        WriteLine("you pull the slowly.");
                        player.Location = 3;
                    }
                    else
                    {
                        WriteLine("You decide to not open the old dust door");
                    }
                }
                WriteLine("Press 'ENTER' to Continue");
                ReadLine();
            }
            if(player.Location == 1)
            {

            }

        }
    }
}
    

