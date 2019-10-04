using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int barrelCapacity = 10;
        private const int totalBullets = 100;

        public Pistol(string name) : base(name: name, bulletsPerBarrel: barrelCapacity, totalBullets: totalBullets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel == 0)
            {
                if (this.TotalBullets <= barrelCapacity)
                {
                    this.BulletsPerBarrel = this.TotalBullets;
                    this.TotalBullets = 0;
                }
                else
                {
                    this.TotalBullets -= barrelCapacity;
                    this.BulletsPerBarrel += barrelCapacity;
                }

            }

            this.BulletsPerBarrel--;

            return 0;
        }
    }
}
