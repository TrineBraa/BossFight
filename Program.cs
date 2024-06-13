using System;
using System.Threading.Channels;
using BossFight;



Boss boss = new Boss(400, 30, 10);
Hero hero = new Hero(100, 20, 40);
Game();
void Game()
{
    Console.WriteLine("Welcome to the battle arena!");
    Console.WriteLine("The battle will shortly begin between the Hero and the boss!");
    Console.WriteLine("\nHere are our opponents!");
    Console.WriteLine();
    hero.ShowHero();
    Console.WriteLine();
    boss.ShowBoss();
    Console.WriteLine();
    Console.WriteLine("Are you ready to begin the battle?");
    Console.WriteLine("Y/N");
    var Response = Console.ReadLine();

    if (Response.ToLower() == "Y".ToLower())
    {
        GameStart( boss, hero);
    }
    else if (Response.ToLower() == "N".ToLower())
    {
        Console.WriteLine("If you don't want to battle you should leave!");
        Environment.Exit(404);
    }
    else
    {
        Console.WriteLine("Please answer: Y or N");
    }

}

void GameStart(object Boss, object Hero)
{
    Console.WriteLine("The battle begins!");
    bool ActiveGame = true;
    while (ActiveGame)
    {
        Console.Clear();
        Console.WriteLine("\nHero reacts first!");
        Console.WriteLine("What does the hero want to do? Attack or Recharge!");
        var HeroReach = Console.ReadLine();
        if (HeroReach.ToLower() == "Attack".ToLower())
        {
            if (hero._stamina == 0)
            {
                Console.WriteLine("Hero has no stamina left and can't attack!");
                Console.WriteLine("Hero has to recharge!");
                hero.Recharge();
            }
            else
            {
                hero.Fight(boss);
            }
        }
        else if (HeroReach.ToLower() == "Recharge".ToLower())
        {
            hero.Recharge();
        }
        else
        {
            Console.WriteLine("\nNot a valid reaction! Hero skipped his turn!");
        }

        Console.WriteLine("\nHero ends his turn, Boss reacts next!");
        Console.WriteLine("\n\tpress a key to continue!");
        Console.ReadKey();
        Console.Clear();

        if (boss._stamina > 0)
        {
            boss.Fight(hero);
           
        }
        else
        {
            boss.Recharge();
        }

       
        Console.WriteLine("\nThe boss ends his turn!");
        Console.WriteLine("\n\tpress a key to continue!");
        Console.ReadKey();
        Console.Clear();

        if (boss._health < 0)
        {
            Console.Clear();
            Console.WriteLine($"\nThe boss has {boss._health} health left, and is dead");
            Console.WriteLine("You win!");
            Console.ReadKey();

            Environment.Exit(100);
        }
        else if (hero._health < 0)
        {
            Console.Clear();
            Console.WriteLine($"\noh no! Hero has {hero._health} health left and died!");
            Console.WriteLine("You lose!");
            Console.ReadKey();
            Environment.Exit(0);
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"\nBoss now has {boss._health} health left!");
            Console.WriteLine($"Hero has {hero._health} health left");
            Console.WriteLine("\nPress to continue battle!");
            Console.ReadKey();
        }


    }

}
















