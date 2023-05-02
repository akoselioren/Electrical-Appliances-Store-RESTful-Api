namespace Entities.Exceptions
{
    public abstract partial class BadRequestException
    {
        public class PriceOutofRangeBadRequestException : BadRequestException
        {
            public PriceOutofRangeBadRequestException() : base("Maksimum fiyat 10'dan büyük olmalı ve 10.000'den küçük olmalıdır.")
            {

            }
        }
    }
}
