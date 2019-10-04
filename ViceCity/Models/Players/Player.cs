using System;
using ViceCity.Common;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        private bool isAlive;

        public Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
        }

        public string Name
        {
            get => this.name;

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(string.Format(format: MessagesConstants.CanNotBeNullOrAWhitespace, arg0: "Player's name"));
                }

                this.name = value;
            }
        }

        public int LifePoints
        {
            get => this.lifePoints;

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(format: MessagesConstants.CannotBeBelowZero, arg0: "Player life points"));
                }

                this.lifePoints = value;
            }
        }

        public bool IsAlive
        {
            get => this.isAlive;

            protected set
            {
                if (this.lifePoints > 0)
                {
                    this.isAlive = true;
                }
                else
                {
                    this.isAlive = false;
                }
            }
        }

        public IRepository<IGun> GunRepository { get; protected set; }

        public void TakeLifePoints(int points)
        {
            this.lifePoints -= points;
            if (this.lifePoints < 0)
            {
                this.lifePoints = 0;
            }
        }
    }
}
