using AbstractFactory.Interfaces;
using AbstractFactory.Products;
using static AbstractFactory.Enums;

namespace AbstractFactory.Factories
{
    public class Apple : Unilago
    {
        public override IDevice CreateDevice(DeviceType deviceType)
        {
            IDevice device = null;
            IAppearanceFactory appearance = new PremiumAppearanceFactory();
            switch (deviceType)
            {
                case DeviceType.Desktop:
                    device = new MacPro(appearance);
                    break;
                case DeviceType.Laptop:
                    device = new MacBookPro(appearance);
                    break;
            }
            return device;
        }
    }
}
