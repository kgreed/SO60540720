using System;
using System.ComponentModel.DataAnnotations;
namespace mynetstdlib
{
    public class kitten
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
    }
}
