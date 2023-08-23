using AbstractFactory.Appearance;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class MediumCostAppearanceFactory : IAppearanceFactory
    {
        public IFinishing CreateFinishing()
        {
            return new Plain();
        }

        public IMaterial CreateMaterial()
        {
            return new Metal();
        }
    }
}
