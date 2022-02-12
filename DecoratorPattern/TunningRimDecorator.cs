namespace DecoratorPattern
{
    public class TunningRimDecorator : CarDecorator
    {
        public TunningRimDecorator(ICar car) : base(car)
        {
        }

        public override string GetCarDetail()
        {
           string detail = base.GetCarDetail();
           detail += "\r\n with tunning rim that kills his mother";
           return detail;
        }
    }
}