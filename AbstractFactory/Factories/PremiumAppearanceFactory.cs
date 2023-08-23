using AbstractFactory.Appearance;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    class PremiumAppearanceFactory : IAppearanceFactory
    {
        public IFinishing CreateFinishing()
        {
            return new Engraved();
        }

        public IMaterial CreateMaterial()
        {
            return new Metal();
        }
    }
}
