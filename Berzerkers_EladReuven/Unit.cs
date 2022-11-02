using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers_EladReuven
{
    internal abstract class Unit
    {
        int _damage { get; set; }
        int _HP { get; }
        Race race { get; set; }

        enum Race
        {
            Human,
            Orc,
            Dork
        }
        virtual public void Attack(Unit unit) //virtual meaning the derrived classes CAN override the method
        {
            
        }

        abstract public void Defend(Unit unit); //abstract meaning the derrived classes HAVE to override the method





    }
}
