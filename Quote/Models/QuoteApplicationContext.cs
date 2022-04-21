using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quote.Models
{
    public class QuoteApplicationContext : DbContext
    { 
        //constructor
        public QuoteApplicationContext (DbContextOptions<QuoteApplicationContext> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Quote = "Whatever our souls are made of, his and mine are the same.",
                    Author = "Emily Bronte",
                    Subject = "Love"



                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Quote = "Moral indignation is jealousy with a halo.",
                    Author = "H. G. Wells",
                    Subject = "Life",
                    Citation = "H. G. Wells (1866-1946)"



                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Quote = "Victory goes to the player who makes the next-to-last mistake.",
                    Author = "Henry Davis",
                    Subject = "Victory",
                    Citation = "Chessmaster Savielly Grigorievitch Tartakower (1887-1956)"



                }
            );
        }

    }
}
