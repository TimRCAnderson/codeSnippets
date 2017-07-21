using System;
using System.ComponentModel.DataAnnotations;

namespace codeSnippets.Models
{
    public class Snippet
    {
        public int ID {get; set;}

        [Required]
        public string Title {get; set;}

        [Required]
        [StringLength(1000)]
        public string Code {get; set;}

        [Required]
        public string Language {get; set;}

        [StringLength(1000)]
        public string Comment {get; set;}
    }
}