using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Luksus.Data;
using System;
using System.Linq;

namespace Luksus.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LuksusContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LuksusContext>>()))
            {
                // Look for any perfume.
                if (context.Perfume.Any())
                {
                    return;   // DB has been seeded
                }

                context.Perfume.AddRange(
                    new Perfume
                    {
                        Name = "Tom Ford Black Orchid",
                        Brand = "Tom Ford",
                        Price = 134.99M,
                        FragranceFamily = "Oriental Floral",
                        Volume = "50",
                        Concentration = "Eau de Parfum",
                        Rating = "3"
                    },

                    new Perfume
                    {
                        Name = "Creed Aventus",
                        Brand = "Creed",
                        Price = 434.99M,
                        FragranceFamily = "Fruity Chypre",
                        Volume = "50",
                        Concentration = "Eau de Parfum",
                        Rating = "3"
                    },

                    new Perfume
                    {
                        Name = "Chanel No. 5",
                        Brand = "Chanel",
                        Price = 137.99M,
                        FragranceFamily = "Floral Aldehyde",
                        Volume = "50",
                        Concentration = "Eau de Parfum",
                        Rating = "4"
                    },

                    new Perfume
                    {
                        Name = "Jo Malone London Peony & Blush Suede",
                        Brand = "Jo Malone London",
                        Price = 139.99M,
                        FragranceFamily = "Floral Fruity",
                        Volume = "50",
                        Concentration = "Cologne",
                        Rating = "2"
                    },

                    new Perfume
                    {
                        Name = "Dior J'adore",
                        Brand = "Dior",
                        Price = 134.99M,
                        FragranceFamily = "Floral",
                        Volume = "50",
                        Concentration = "Eau de Parfum",
                        Rating = "5"
                    },

                    new Perfume
                    {
                        Name = "Byredo Gypsy Water",
                        Brand = "Byredo",
                        Price = 189.99M,
                        FragranceFamily = "Woody Aromatic",
                        Volume = "50",
                        Concentration = "Eau de Parfum",
                        Rating = "3"
                    },

                    new Perfume
                    {
                        Name = "Acqua di Parma Colonia",
                        Brand = "Acqua di Parma",
                        Price = 179.99M,
                        FragranceFamily = "Citrus Aromatic",
                        Volume = "50",
                        Concentration = "Eau de Cologne",
                        Rating = "5"
                    },

                    new Perfume
                    {
                        Name = "Guerlain Shalimar",
                        Brand = "Guerlain",
                        Price = 119.99M,
                        FragranceFamily = "Oriental",
                        Volume = "50",
                        Concentration = "Eau de Parfum",
                        Rating = "3"
                    },

                    new Perfume
                    {
                        Name = "Amouage Reflection Woman",
                        Brand = "Amouage",
                        Price = 299.99M,
                        FragranceFamily = "Floral",
                        Volume = "50",
                        Concentration = "Eau de Parfum",
                        Rating = "2"
                    },

                    new Perfume
                    {
                        Name = "Hermes Terre d'Hermes",
                        Brand = "Hermes",
                        Price = 149.99M,
                        FragranceFamily = "Woody Spicy",
                        Volume = "50",
                        Concentration = "Eau de Toilette",
                        Rating = "5"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
