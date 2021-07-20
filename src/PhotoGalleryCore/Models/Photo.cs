using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhotoGalleryCore.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }

        [Required(ErrorMessage ="وصف الصورة مطلوب")]
        [Display(Name = "الوصف")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "تاريخ الألتقاط")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Url]
        public string Path { get; set; }

        [Range(1, 5)]
        public int?  Rating { get; set; }


        [Required(ErrorMessage ="عنوان الصورة مطلوب")]
        [StringLength(100)]
        [Display(Name ="العنوان")]
        public string Caption { get; set; }


        public ICollection<Tag> Tags { get; set; }
        public ICollection<Comment> Comments { get; set; }
    };
}