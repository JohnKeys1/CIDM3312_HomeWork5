using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorPagesMovie.Models

{
   
    public class Review
    {
       
        public int ID { get; set; }
         [Required]
          [Range(1, 5)]
        public int Score { get; set; }
         public int MovieID { get; set; }//foreign key
        
         public Movie movie  { get; set; }//nav prop


         
        
    }
}