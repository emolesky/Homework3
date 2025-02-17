//Written by Emilynn Molesky 
//2/11/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunting
{
    public class Manticore
    {
        private int distance = -1;
        private int health = 10;

        public int Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public Manticore(int distance)
        {
            this.distance = distance;
        }

        public void TakeDamage(int damage)
        {
            this.health -= damage;
            if (this.health < 0)
            {
                this.health = 0;
            }
        }
    }
}
