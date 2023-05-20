namespace Entities.Exceptions
{
    public sealed class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException(int id) : base($"istek atmış oldugunuz : '{id}' id'sine ait kategori bulunamadı.")
        {
        }
    }
}