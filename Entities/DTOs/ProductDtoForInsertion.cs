using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public record ProductDtoForInsertion :ProductDtoForManipulation
    {
        [Required(ErrorMessage = "Kategori id boş geçilemez.")]
        public int CategoryId { get; init; }
    }
} 
