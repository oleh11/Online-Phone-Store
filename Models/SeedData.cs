using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0)
            {
                var s1 = new Supplier
                {
                    Name = "Nike",
                    City = "Portland",
                    State = "OR"
                };
                var s2 = new Supplier
                {
                    Name = "Sperrys",
                    City = "Chicago",
                    State = "IL"
                };
                var s3 = new Supplier
                {
                    Name = "Fancy Shamancy",
                    City = "Los Angeles",
                    State = "CA"
                };

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Nike Zoom",
                        Image = "vomero.jpg",
                        Description = "Durable for Long Distance",
                        Category = "Running",
                        Price = 120,
                        Supplier = s1,
                        Ratings = new List<Rating> {
                             new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                     new Product
                     {
                         Name = "Brown Sperrys",
                         Image = "brownSperry.jpg",
                         Description = "Comfortable and Stylish",
                         Category = "Casual",
                         Price = 95.00m,
                         Supplier = s2,
                         Ratings = new List<Rating> {
                             new Rating { Stars = 2 }, new Rating { Stars = 5 }}
                     },
                     new Product
                     {
                         Name = "Black Dress Shoes",
                         Image = "blackDress.jpg",
                         Description = "Quality Shoes",
                         Category = "Dress",
                         Price = 100.00m,
                         Supplier = s3,
                         Ratings = new List<Rating> {
                             new Rating { Stars = 1 }, new Rating { Stars = 3 }}
                     },
                     new Product
                     {
                         Name = "Nike Free 2.0",
                         Image = "free.jpg",
                         Description = "Lightweight and Flexible",
                         Category = "Running",
                         Price = 110.00m,
                         Supplier = s1,
                         Ratings = new List<Rating> { new Rating { Stars = 3 } }
                     },
                     new Product
                     {
                         Name = "Navy Blue Sperrys",
                         Image = "blueSperry.jpg",
                         Description = "Comfortable and cool color",
                         Category = "Casual",
                         Price = 90.00m,
                         Supplier = s2,
                         Ratings = new List<Rating> { new Rating { Stars = 1 },
                             new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                     },
                     new Product
                     {
                         Name = "Dockers",
                         Image = "dockers.jpg",
                         Description = "Traditional Fancy Shoes",
                         Category = "Dress",
                         Price = 150.00m,
                         Supplier = s3,
                         Ratings = new List<Rating> { new Rating { Stars = 5 },
                             new Rating { Stars = 4 }}
                     },
                     new Product
                     {
                         Name = "Nike Zoom Pegasus",
                         Image = "pegasus.jpg",
                         Description = "All Around great running shoes",
                         Category = "Running",
                         Price = 130.00m,
                         Supplier = s1,
                         Ratings = new List<Rating> { new Rating { Stars = 3 } }
                     },
                     new Product
                     {
                         Name = "White Sperrys",
                         Image = "whiteSperry.jpg",
                         Description = "Comfortable and stand out",
                         Category = "Casual",
                         Price = 75,
                         Supplier = s2,
                         Ratings = new List<Rating> { new Rating { Stars = 4 } }
                     },
                     new Product
                     {
                         Name = "Super Pricy Dress Shoes",
                         Image = "superPricey.jpg",
                         Description = "Try on some of these!",
                         Category = "Dress",
                         Price = 200.00m,
                         Supplier = s3,
                         Ratings = new List<Rating> { new Rating { Stars = 3 } }
                     },

                     new Product
                     {
                         Name = "Nike Zoom Structure",
                         Image = "structure.jpg",
                         Description = "Great support for long runs",
                         Category = "Running",
                         Price = 115.00m,
                         Supplier = s1,
                         Ratings = new List<Rating> { new Rating { Stars = 4 } }
                     },

                     new Product
                     {
                         Name = "Red Sperrys",
                         Image = "redSperry.jpg",
                         Description = "Show off your style",
                         Category = "Casual",
                         Price = 95,
                         Supplier = s2,
                         Ratings = new List<Rating> { new Rating { Stars = 4 } }
                     },

                     new Product
                     {
                         Name = "Brown Dress Shoes",
                         Image = "brownDress.jpg",
                         Description = "Great for all events",
                         Category = "Dress",
                         Price = 130,
                         Supplier = s3,
                         Ratings = new List<Rating> { new Rating { Stars = 4 } }
                     });
                context.SaveChanges();
            }
        }

    }
}
