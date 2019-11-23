using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    // Strategy pattern
    public class CurrentWeapon
    {
        private Weapon weapon;

        public void SwitchWeapon(Weapon weapon)
        {
            weapon = this.weapon;
        }

        public void Attack()
        {
            weapon.use();
        }
    }

    
    public interface Weapon
    {
        void use();

        int damange();
    }

    public class Sword : Weapon
    {
        public int damange()
        {
            return 80;
        }

        public void use()
        {
            Console.WriteLine("Using Sword");
        }
    }

    public class Axe : Weapon
    {
        public void use()
        {
            Console.WriteLine("Using Axe");
        }

        public int damange()
        {
            return 90;
        }
    }

    public class Club : Weapon
    {
        public void use()
        {
            Console.WriteLine("Using Club");
        }

        public int damange()
        {
            return 65;
        }
    }

    public class Bow : Weapon
    {
        public void use()
        {
            Console.WriteLine("Using Bow");
        }

        public int damange()
        {
            return 75;
        }
    }

    public class Blade : Weapon
    {
        public void use()
        {
            Console.WriteLine("Using Blade");
        }

        public int damange()
        {
            return 50;
        }
    }


    public class WoodenSword : Weapon
    {
        public void use()
        {
            Console.WriteLine("Using Wooden Sword");
        }

        public int damange()
        {
            return 20;
        }
    }

}
