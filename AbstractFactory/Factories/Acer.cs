using AbstractFactory.Interfaces;
using AbstractFactory.Products;
using static AbstractFactory.Enums;

namespace AbstractFactory.Factories
{
    public class Acer : Unilago
    {
        public override IDevice CreateDevice(DeviceType deviceType)
        {
            IDevice device = null;
            IAppearanceFactory appearance = new LowCostAppearanceFactory();
            switch (deviceType)
            {
                case DeviceType.Desktop:
                    device = new Pc(appearance);
                    break;
                case DeviceType.Laptop:
                    device = new Laptop(appearance);
                    break;
            }
            return device;
        }
    }
}
