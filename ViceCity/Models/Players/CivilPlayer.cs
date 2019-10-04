namespace ViceCity.Models.Players
{
    public class CivilPlayer : Player
    {
        private const int initialLifePoints = 90;

        public CivilPlayer(string name) : base(name: name, lifePoints: initialLifePoints)
        {
        }
    }
}
