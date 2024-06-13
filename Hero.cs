using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Hero
    {
        public int _health;
        private int _strenght;
        public int _stamina;

        public Hero(int Health, int Strenght, int Stamina)
        {
            _health = Health;
            _strenght = Strenght;
            _stamina = Stamina;
        }

        public void ShowHero()
        {
            Console.WriteLine("\nHero:");
            Console.WriteLine($"\tHealth: {_health}");
            Console.WriteLine($"\tStrength: {_strenght}");
            Console.WriteLine($"\tStamina: {_stamina}");
        }


        public void Fight(Boss boss )
        {
            _stamina -= 10;
            Console.WriteLine("Hero attacks boss for 20 damage!");
            boss.BossLooseHealth(20);
            Console.WriteLine($"Boss get's hit and has {boss._health} health left");
            Console.WriteLine($"Hero has {_stamina} stamina left!");

        }

        public void Recharge()
        {
            _stamina += 40;
            Console.WriteLine($"Hero uses recharge and now has {_stamina} stamina" );
            Thread.Sleep(2000);
            Console.Clear();
            ShowHero();
        }

        public void HeroLooseHealth(int Damage)
        {
            _health -= Damage;
        }

    }
}
