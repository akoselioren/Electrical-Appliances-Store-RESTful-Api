namespace Entities.Exceptions
{
    public sealed class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(int id) : base($"Hata : İşlem Yapmak istediğniz id'si : {id} 'olan ürün bulunamadı.")
        {

        }
    }
}