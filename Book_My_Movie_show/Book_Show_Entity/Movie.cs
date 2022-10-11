using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Book_Show_Entity
{
    public class Movie
    {
        [Key]//primary key is id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generate col
        public int Id { get; set; }
        public string Name { get; set; }
        public string MovieDesc { get; set; }
        public string MovieType { get; set; }
    }
}
