namespace AbstractFactory.Factories
{
    public class BalaxyFactory : DeviceFactory
    {
        public override Device CreateLaptop() => new Laptop();
        public override Device CreateNetbook() => new Netbook();
        public override Device CreateEBook() => new EBook();
        public override Device CreateSmartphone() => new Smartphone();
    }
}
