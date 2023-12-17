using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o título")]
        [MinLength(3, ErrorMessage = "A categoria deve ter pelo menos 3 caracteres")]
        [MaxLength(60, ErrorMessage = "A categoria deve ter pelo menos 3 caracteres")]
        public string Title { get; set; } = string.Empty;
    }
}