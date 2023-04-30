using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public abstract record ProductDtoForManipulation
    {
        [Required(ErrorMessage = "Hata : Ürün başlık alanı boş geçilemez.")]
        [MinLength(2, ErrorMessage = "Hata : Başlık alanı en az 2 karakter olamalıdır.")]
        [MaxLength(50, ErrorMessage = "Hata : Başlık alanı en fazla 50 karakter olamalıdır.")]
        public string Title { get; init; }
        [Required(ErrorMessage = "Hata : Ürün fiyat alanı boş geçilemez.")]
        [Range(10,5000, ErrorMessage = "Hata : Ürün Fiyatı min:10 TL , max:5000 TL olamalıdır.")]
        public decimal Price { get; init; }
    }
}
