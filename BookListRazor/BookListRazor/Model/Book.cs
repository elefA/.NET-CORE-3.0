using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key] // Using this import Key from system.componentModel.DataAnnotation is Auto Increment
        public int Id { get; set; }

        [Required] //Required Field
        public string Name{ get; set; }

        public string Author { get; set; }
    }
}
