using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CInemaBookings.Data;
using System;
using System.Linq;
namespace CInemaBookings.Models
{
    public static class DataSeeding
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new CInemaBookingsContext(serviceProvider.GetRequiredService<DbContextOptions<CInemaBookingsContext>>()))
            {
                if (context.Movie.Any()) {
                    //this means the DB has already been seeded
                    return;
                }

                context.Movie.AddRange(
                    new Movie {
                        MovieName = "Iron Man",
                        Genre = "Sci-Fi/Action",
                        RunningTime = "2 hours 10 mins",
                        MainLead = "Robert Downey Jr."
                    },
                    new Movie
                    {
                        MovieName = "Real Steel",
                        Genre = "Sci-Fi",
                        RunningTime = "2 hours 30 mins",
                        MainLead = "Hugh Jackman"
                    },
                    new Movie
                    {
                        MovieName = "Avengers: EndGame",
                        Genre = "Action/Super-hero",
                        RunningTime = "3 hours 10 mins",
                        MainLead = "Robert Downey Jr., Chris Evans"
                    },
                    new Movie
                    {
                        MovieName = "The Conjuring",
                        Genre = "Horror/Supernatural",
                        RunningTime = "1 hour 40 mins",
                        MainLead = "Unknown"
                    }
                );

                context.SaveChanges();
            }
        }

    }
}
