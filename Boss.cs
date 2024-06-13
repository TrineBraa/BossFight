using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Boss
    {
        public int _health;
        private int _strenght;
        public int _stamina;

        public Boss(int Health, int Strenght, int Stamina)
        {
            _health = Health;
            _strenght = Strenght;
            _stamina = Stamina;
        }

        public void ShowBoss()
        {
            Console.WriteLine("\nBoss:");
            Console.WriteLine($"\tHealth: {_health}");
            Console.WriteLine($"\tStrength: {_strenght}");
            Console.WriteLine($"\tStamina: {_stamina}");
        }

        public void Fight(Hero hero)
        {
            _stamina -= 10;
            Console.WriteLine($"\nBoss strikes Hero for {_strenght} damage");
            Console.WriteLine($"Boss used 10 stamina and now has {_stamina} stamina");
            Random randAttack = new Random();
            int RandomAttack = randAttack.Next(0,30);

       
            hero.HeroLooseHealth(RandomAttack);
        }

        public void Recharge()
        {
            _stamina += 10;
            Console.WriteLine($"\nThe boss recharges and has {_stamina} stamina");
            Thread.Sleep(2000);
            Console.Clear();
            ShowBoss();
        }


        public void BossLooseHealth(int Damage)
        {
            _health -= Damage;
        }


    }
}
