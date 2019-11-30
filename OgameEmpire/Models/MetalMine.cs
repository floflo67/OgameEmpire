using System;

namespace OgameEmpire.Models
{
    public class MetalMine : MineBase
    {
        public MetalMine(int level, int plasmaTechLevel, int universeAcceleration) : base(level, plasmaTechLevel, universeAcceleration)
        {
        }

        /* Possible improvement :
         * - Save cost
         * private static readonly double[] CrystalLevelCost = new double[50];
         * private static readonly double[] MetalLevelCost = new double[50];
         * */

        public override int BaseCrystalCost => 15;
        public override int BaseDeutCost => 0;
        public override int BaseMetalCost => 60;

        public override double GetCrystalLevelCost(int level) => BaseCrystalCost * Math.Pow(1.5, level - 1);

        public override double GetDeutLevelCost(int level) => 0;

        public override double GetEnergyConsumption() => 10 * Level * Math.Pow(1.1, Level);

        public override double GetMetalLevelCost(int level) => BaseMetalCost * Math.Pow(1.5, level - 1);

        public override double GetProduction() => 30 * (1 + PlasmaTechLevel / 100 * 1) * UniverseAcceleration * Level * Math.Pow(1.1, Level) + 30 * UniverseAcceleration;
    }
}