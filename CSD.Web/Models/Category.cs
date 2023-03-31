﻿using System.ComponentModel.DataAnnotations;

namespace CSD.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Имя")]
        [Required]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Родительская категория")]
        [Required]
        public int ParentId { get; set; } = 0;
        public List<Post>? Posts { get; set; }
    }
}
