﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game1
{
    internal class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 120;
        public int Attack { get; set; } = 25;
        public int Location { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();


        public void rest(List<string> options, Player player)
        {
            PlayArea playarea = new PlayArea();
            Combat combat = new Combat();

            options.Clear();
            options.Add("30 Minutes");
            options.Add("1 Hour");
            options.Add("1 Hour 30 Minutes");
            WriteLine("How long do you want to rest?");
            int sleeptime = Utility.UserOptions(options);
            if (sleeptime == 0)
            {
                Random monsterAttack = new Random();
                Clear();
                //A Haiku writen by Matsuo BashŌ (1644 - 1694)
                WriteLine("Seek not to follow,\nIn the footsteps of wise men-\nSeel that which they sought. \n");
                if (monsterAttack.Next(0, 2) == 0 || monsterAttack.Next(0, 2) == 1)
                {
                    WriteLine("You wake up after your nap a bit rested");
                    player.Health += 30;
                    WriteLine("Press 'ENTER' to Continue");
                    ReadLine();
                    playarea.Play();
                }
                else
                {
                    WriteLine("You are rudly awakened by a monster");
                    Enemy enemy1 = new Enemy()
                    {
                        Name = "Goblin",
                        Health = 100,
                        Attack = 10
                    };
                    combat.SetUp(player, enemy1);
                }

            }
            else if (sleeptime == 1)
            {
                Random monsterAttack = new Random();
                Clear();
                //A Haiku writen by Dairin Soto (1480 - 1568)
                WriteLine("Face to face with death\nI unsheathe my sharpened sword-\nThe blade is broken \n\n");
                if (monsterAttack.Next(0, 5) == 0 || monsterAttack.Next(0, 5) == 2)
                {
                    WriteLine("You wake up after your nap a bit rested");
                    player.Health += 60;
                    WriteLine("Press 'ENTER' to Continue");
                    ReadLine();
                    playarea.Play();
                }
                else
                {
                    WriteLine("You are rudly awakened by a monster");
                    WriteLine("Press 'ENTER' to Continue");
                    ReadLine();
                    Enemy enemy1 = new Enemy()
                    {
                        Name = "Goblin",
                        Health = 100,
                        Attack = 10
                    };
                    combat.SetUp(player, enemy1);
                }
            }
            else if (sleeptime == 2)
            {
                Random monsterAttack = new Random();
                Clear();
                //A Haiku writen by Dairin Soto (1480 - 1568)
                WriteLine("Empty-Handed\nI entered this world,\nBarefoot I leave it. \n\n");
                if (monsterAttack.Next(0, 8) == 0 || monsterAttack.Next(0, 8) == 2 || monsterAttack.Next(0, 8) == 4 || monsterAttack.Next(0, 8) == 6)
                {
                    WriteLine("You wake up after your nap a Well rested");
                    player.Health += 90;
                    WriteLine("Press 'ENTER' to Continue");
                    ReadLine();
                    playarea.Play();
                }
                else
                {
                    WriteLine("You are rudly awakened by a monster");
                    Enemy enemy1 = new Enemy()
                    {
                        Name = "Goblin",
                        Health = 100,
                        Attack = 10
                    };
                    combat.SetUp(player, enemy1);
                }
            }
        }
    }
}
