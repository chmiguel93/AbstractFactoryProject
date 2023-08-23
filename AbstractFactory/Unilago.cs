using AbstractFactory.Interfaces;
using static AbstractFactory.Enums;

namespace AbstractFactory
{
    public abstract class Unilago
    {
        public abstract IDevice CreateDevice(DeviceType deviceType);

        public IDevice BuyDevice(DeviceType deviceType)
        {
            IDevice device = CreateDevice(deviceType);
            device.Assemble();
            device.Deliver();
            return device;
        }
    }
}
