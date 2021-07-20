using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhotoGalleryCore.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required]
        [Display(Name = "الوصف")]
        [StringLength(maximumLength: 500)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "تاريخ التعليق")]
        public DateTime Date { get; set; }

        [Display(Description = "أسم المعلق")]
        public string AuthorName { get; set; }

        public Photo Photo { get; set; }
    };
}