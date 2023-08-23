using AbstractFactory.Appearance;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class LowCostAppearanceFactory : IAppearanceFactory
    {
        public IFinishing CreateFinishing()
        {
            return new Plain();
        }

        public IMaterial CreateMaterial()
        {
            return new Plastic();
        }
    }
}
