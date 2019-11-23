using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    // Prototype pattern

   public abstract class Character
    {
        public string name { get; set; }
        public int level { get; set; }
        public string outfit { get; set; }
        public string defaultWeapon { get; set; }

        public abstract Character Clone();

    }

    public class Mage : Character
    {
        public Mage(string name)
        {
            name = this.name;
        }

        public override Character Clone()
        {
            return (Mage)this.MemberwiseClone();
        }

    }
    
    public class Knight : Character
    {
        public Knight(string name)
        {
            name = this.name;
        }

        public override Character Clone()
        {
            return (Knight)this.MemberwiseClone();
        }
    }


}
