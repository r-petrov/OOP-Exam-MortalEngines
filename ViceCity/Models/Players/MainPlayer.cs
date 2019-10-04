using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const string name = "Tommy Vercetti";
        private const int initialLifePoints = 100;

        public MainPlayer() : base(name: name, lifePoints: initialLifePoints)
        {
        }
    }
}
