using System;
using System.ComponentModel.DataAnnotations;

namespace PhotoGalleryCore.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        public string Name { get; set; }
    };
}