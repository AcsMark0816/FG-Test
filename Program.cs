using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Numerics;

namespace RevengeOfFG
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Wizard> wizards = new List<Wizard>();
            List<string> inevtory = new List<string>();
            List<FG> fGs = new List<FG>();
            List<BossesClass> bosses = new List<BossesClass>();


            fGs = FGFileManager.FileReader("FG.txt");
            wizards = FileManager.FileReader("wizard.txt");
            bosses = BossesFile.FileReader("Bosses.txt");





            Console.WriteLine("Welcome to revenge of FG");
            Console.WriteLine("Enter your name");
            string Karakteredneve = Console.ReadLine();
            Console.WriteLine("Hello FG");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("So you got banished from the Egressy the capital city of Hungary by the holy trinity and you want to get your revenge");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Choose your element FG");
            List<string> elements = new List<string>();

            foreach (var elemnt in wizards)
            {
                elements.Add(elemnt.Type);
            }
            foreach (var elemnt in elements)
            {
                Console.WriteLine(elemnt);
            }
            string EleMent = Console.ReadLine();

            foreach (var elemnt in elements)
            {
                if (EleMent == "Fire")
                {
                    Console.WriteLine("FG is now the true knight of fire");
                    break;
                }
                if (EleMent == "Water")
                {
                    Console.WriteLine("FG is now the king of all seas");
                    break;
                }
                if (EleMent == "Earth")
                {
                    Console.WriteLine("FG is now the creator of all lands");
                    break;
                }
                if (EleMent == "Air")
                {
                    Console.WriteLine("FG is now the true cloud rider");
                    break;
                }
                if (EleMent == "Electric")
                {
                    Console.WriteLine("FG is now the ligtning master");
                    break;
                }
                if (EleMent == "Ice")
                {
                    Console.WriteLine("FG is now the frosty puff");
                    break;
                }
                if (EleMent == "Dark")
                {
                    Console.WriteLine("FG is now the king of all the deads");
                    break;
                }
                if (EleMent == "Light")
                {
                    Console.WriteLine("FG is now the Holy one");
                    break;
                }
                if (EleMent == "Posion")
                {
                    Console.WriteLine("FG is now the contoller of all the diseses");
                    break;
                }
                if (EleMent == "Dream")
                {
                    Console.WriteLine("FG is now the one who makes dreams come true");
                    break;
                }

            }
            bool gameRunning = true;
            bool startRevenge = false;
            bool elsoKiiras = true;

           
            while (gameRunning)
            {
                if (elsoKiiras)
                {
                    Console.WriteLine("\nYou just woke up in the village...");
                    elsoKiiras = false;
                }
                Console.WriteLine("1 - Visit Merchant");
                Console.WriteLine("2 - Meet with Locals");
                Console.WriteLine("3 - Start Revenge Path (FINAL)");
                Console.WriteLine("4 - Exit Game");

                string choice = Console.ReadLine();

                switch (choice)
                {
                   
                    case "1":
                        bool merchantLoop = true;

                        while (merchantLoop)
                        {
                            Console.WriteLine("\nYou met Tomika the merchant of 67.");
                            Console.WriteLine("1 - Buy something");
                            Console.WriteLine("2 - Leave");

                            string merchantChoice = Console.ReadLine();

                            switch (merchantChoice)
                            {
                                case "1":
                                    Console.WriteLine("\n1 - Bone Helmet (200)");
                                    Console.WriteLine("2 - Vampire Ring (700)");
                                    Console.WriteLine("3 - Grasas Old Karate Belt (1000)");

                                    string buyChoice = Console.ReadLine();

                                    foreach (var stat in fGs)
                                    {
                                        int price = 0;
                                        string itemName = "";

                                        switch (buyChoice)
                                        {
                                            case "1":
                                                price = 200;
                                                itemName = "Bone Helmet";
                                                break;

                                            case "2":
                                                price = 700;
                                                itemName = "Vampire Ring";
                                                break;

                                            case "3":
                                                price = 1000;
                                                itemName = "Grasas Old Karate Belt";
                                                break;

                                            default:
                                                Console.WriteLine("Invalid choice.");
                                                break;
                                        }

                                       
                                        if (stat.Money >= price)
                                        {
                                            stat.Money -= price;
                                            inevtory.Add(itemName);

                                            if (buyChoice == "1")
                                                stat.Defense += 5;
                                            if (buyChoice == "2")
                                                stat.Health += 50;
                                            if (buyChoice == "3")
                                                stat.Damage += 15;

                                            Console.WriteLine($"Sikeres vásárlás! Maradék pénz: {stat.Money}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nincs elég pénzed!");
                                        }
                                    }
                                    break;

                                case "2":
                                    merchantLoop = false;
                                    break;
                            }
                        }
                        break;

                    
                    case "2":
                        bool localsLoop = true;

                        while (localsLoop)
                        {
                            Console.WriteLine("\nThe villagers gather around a statue...");

                           
                            if (inevtory.Contains("Vampire Ring"))
                            {
                                Console.WriteLine("The statue reacts to your Vampire Ring!");
                                Console.WriteLine("Majer the Vampire King appears!");




                                inevtory.Remove("Vampire Ring");
                                double playerHP = 0;
                                double enemyHP = 0;
                                double playerAttack = 0;
                                double enemyAttack = 35;

                                playerHP -= 50;
                                

                                foreach (var stat in fGs)
                                {
                                    playerHP = playerHP += stat.Health;
                                    playerAttack = playerAttack + stat.Damage;
                                }
                                foreach(var stat in bosses)
                                {
                                    enemyHP = enemyHP += stat.health;
                                    enemyAttack = enemyAttack += stat.damage;

                                }
                                Random r = new Random();

                                while (playerHP > 0 && enemyHP > 0)
                                {
                                    Console.WriteLine("\n1 - Attack");
                                    Console.WriteLine("2 - Heal");
                                    Console.WriteLine("3 - Dodge");

                                    string fightChoice = Console.ReadLine();

                                    switch (fightChoice)
                                    {
                                        case "1":
                                            enemyHP -= playerAttack;
                                            Console.WriteLine("You attack!");
                                            break;

                                        case "2":
                                            int heal = r.Next(100, 130);
                                            playerHP += heal;
                                            Console.WriteLine($"You healed {heal}");
                                            break;

                                        case "3":
                                            int dodge = r.Next(1, 100);
                                            if (dodge > 50)
                                            {
                                                Console.WriteLine("You dodged!");
                                                enemyAttack = 0;
                                            }
                                            break;
                                    }

                                    if (enemyHP <= 0)
                                    {
                                        Console.WriteLine("You defeated Majer!");
                                        Console.WriteLine("He dropped the true vampire ring");
                                        inevtory.Add("True Vampire Ring");
                                        localsLoop = false;
                                        break;
                                    }

                                    playerHP -= enemyAttack;
                                    double enemyHeal = playerAttack * 0.73;
                                    if(enemyHP <= 30)
                                    {
                                        Console.WriteLine("The true vampire form (LifeSteal)");
                                        enemyHP += enemyHeal;
                                        enemyAttack += 2;

                                    }
                                    Console.WriteLine($"Enemy hits for {enemyAttack}");

                                    Console.WriteLine($"Player HP: {playerHP}");
                                    Console.WriteLine($"Enemy HP: {enemyHP}");

                                    if (playerHP <= 0)
                                    {
                                        Console.WriteLine("You died...");
                                        gameRunning = false;
                                        localsLoop = false;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nothing happens...");
                                Console.WriteLine("Maybe something special is required.");
                                localsLoop = false;
                            }
                        }
                        break;

                   
                    case "3":
                        Console.WriteLine("\nYou leave the village behind.");
                        Console.WriteLine("There is no turning back...");
                        startRevenge = true;
                        gameRunning = false; 
                        break;

                    case "4":
                        gameRunning = false;
                        break;
                }
            }

            
            if (startRevenge)
            {
                bool revengeLoop = true;

                Console.WriteLine("\n--- THE ROAD OF REVENGE ---");

                while (revengeLoop)
                {
                    Console.WriteLine("You walk alone...");
                    Console.WriteLine("1 - Keep walking");
                    Console.WriteLine("2 - Accept fate");

                    string roadChoice = Console.ReadLine();

                    switch (roadChoice)
                    {
                        case "1":
                            Console.WriteLine("The road is endless...");
                            break;

                        case "2":
                            Console.WriteLine("Your revenge story ends here.");
                            revengeLoop = false;
                            break;
                    }
                }
            }
        }
    }
}