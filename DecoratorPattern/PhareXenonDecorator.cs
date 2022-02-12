using System;

namespace DecoratorPattern
{
    public class XenonHeadlightDecorator : CarDecorator
    {
        public XenonHeadlightDecorator(ICar car) : base(car)
        {
        }

        public override string GetCarDetail()
        {
            string detail = base.GetCarDetail();
            detail += "\r\n with xenon headlight that kills his mother";
            return detail;
        }
    }
}