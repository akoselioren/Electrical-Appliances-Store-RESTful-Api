namespace Entities.DTOs
{
    public record ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
