using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLAB1.Models
{
    public class Movie
    {
        [Key]
        //Tells c# that id is out primary key in sql table
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Error: Title Must be no more than 30 characters long")]
        public string Title { get; set; }

        public string Genre { get; set; }

        [Required]
        [Range(1880, 2021, ErrorMessage = "Error: Year must be between 1880 and 2021")]
        public int Year { get; set; }

        public string Actors { get; set; }
        public string Directors { get; set; }

        public string Runtime { get; set; }
    }
}
 