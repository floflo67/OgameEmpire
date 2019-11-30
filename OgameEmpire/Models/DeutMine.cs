using System;

namespace OgameEmpire.Models
{
    public class DeutMine : MineBase
    {
        public DeutMine(int level, int plasmaTechLevel, int universeAcceleration, int averageTemperature) : base(level, plasmaTechLevel, universeAcceleration)
        {
            AverageTemperature = averageTemperature;
        }

        /* Possible improvement :
         * - Save cost
         * private static readonly double[] CrystalLevelCost = new double[50];
         * private static readonly double[] MetalLevelCost = new double[50];
         * */

        public override int BaseCrystalCost => 75;
        public override int BaseDeutCost => 0;
        public override int BaseMetalCost => 225;

        private int AverageTemperature { get; }

        public override double GetCrystalLevelCost(int level) => BaseCrystalCost * Math.Pow(1.5, level - 1);

        public override double GetDeutLevelCost(int level) => 0;

        public override double GetEnergyConsumption() => 20 * Level * Math.Pow(1.1, Level);

        public override double GetMetalLevelCost(int level) => BaseMetalCost * Math.Pow(1.5, level - 1);

        public override double GetProduction() => 10 * (1 + PlasmaTechLevel / 100 * 0.33) * UniverseAcceleration * (Level * Math.Pow(1.1, Level)) * (1.36 - 0.004 * AverageTemperature);
    }
}