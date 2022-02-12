namespace DecoratorPattern
{
    public class CarDecorator : ICar
    {
        private ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetCarDetail()
        {
            return _car.GetCarDetail();
        }
    }
}