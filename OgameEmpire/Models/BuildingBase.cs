namespace OgameEmpire.Models
{
    public abstract class BuildingBase
    {
        public BuildingBase(int level)
        {
            Level = level;
        }

        public abstract int BaseCrystalCost { get; }

        public abstract int BaseDeutCost { get; }

        public abstract int BaseMetalCost { get; }

        public int Level { get; }

        public abstract double GetCrystalLevelCost(int level);

        public abstract double GetDeutLevelCost(int level);

        public abstract double GetMetalLevelCost(int level);

        public double GetTotalCost() => GetTotalCrystalCost() + GetTotalDeutCost() + GetTotalMetalCost();

        public double GetTotalCrystalCost()
        {
            double cost = 0;
            for (int i = 1; i < Level; i++)
            {
                cost += GetCrystalLevelCost(i);
            }
            return cost;
        }

        public double GetTotalDeutCost()
        {
            double cost = 0;
            for (int i = 1; i < Level; i++)
            {
                cost += GetDeutLevelCost(i);
            }
            return cost;
        }

        public double GetTotalMetalCost()
        {
            double cost = 0;
            for (int i = 1; i < Level; i++)
            {
                cost += GetMetalLevelCost(i);
            }
            return cost;
        }

        public double GetTotalPoints() => GetTotalCost() / 1000;
    }
}