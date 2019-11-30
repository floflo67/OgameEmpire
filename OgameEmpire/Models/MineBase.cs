namespace OgameEmpire.Models
{
    public abstract class MineBase : BuildingBase
    {
        public MineBase(int level, int plasmaTechLevel, int universeAcceleration) : base(level)
        {
            PlasmaTechLevel = plasmaTechLevel;
            UniverseAcceleration = universeAcceleration;
        }

        public int PlasmaTechLevel { get; }
        public int UniverseAcceleration { get; }

        public abstract double GetEnergyConsumption();

        public abstract double GetProduction();
    }
}