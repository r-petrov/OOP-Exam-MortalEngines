using System;
using ViceCity.Common;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;
        private bool canFire;

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
        }

        public string Name
        {
            get => this.name;

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(format: MessagesConstants.CanNotBeNullOrAWhitespace, arg0: "Player's name"));
                }

                this.name = value;
            }
        }

        public int BulletsPerBarrel
        {
            get => this.bulletsPerBarrel;

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(format: MessagesConstants.CannotBeBelowZero, arg0: "Bullets"));
                }

                this.bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get => this.totalBullets;

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(format: MessagesConstants.CannotBeBelowZero, arg0: "Total bullets"));
                }

                this.totalBullets = value;
            }
        }

        public bool CanFire
        {
            get => this.canFire;

            protected set
            {
                if (this.totalBullets > 0)
                {
                    this.canFire = true;
                }
                else
                {
                    this.canFire = false;
                }
            }
        }

        public abstract int Fire();
    }
}
