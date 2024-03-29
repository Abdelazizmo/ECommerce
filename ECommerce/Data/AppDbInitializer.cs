﻿using ECommerce.Models;
using ECommerce.Enums.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var applicationservices = builder.ApplicationServices.CreateScope()) 
            {
                var context = applicationservices.ServiceProvider.GetService<ECommerceDbContext>();
                context.Database.EnsureCreated();

                // Category
                if (!context.Categories.Any())
                {
                    var categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "C1",
                            Description = "C1"
                        },
                         new Category()
                        {
                            Name = "C2",
                            Description = "C2"
                        },
                          new Category()
                        {
                            Name = "C3",
                            Description = "C3"
                        }
                    };
                    context.Categories.AddRange(categories);
                    context.SaveChanges();

                }
                //Product
                if (!context.Products.Any())
                {
                    var products = new List<Product>()
                    {
                        new Product()
                        {
                            Name = "P1",Description = "D1", ImagrURL="http....",Price=159,
                            ProductColor = ProductColor.Red, CategoryId=1
                        },
                         new Product()
                        {
                            Name = "P2",Description = "D2", ImagrURL="http....",Price=200,
                            ProductColor = ProductColor.Green, CategoryId=2
                        },
                          new Product()
                        {
                            Name = "P3",Description = "D3", ImagrURL="http....",
                            ProductColor = ProductColor.Blue, CategoryId=3
                        }
                    };

                    context.Products.AddRange(products);
                    context.SaveChanges();
                };
                
            }

        }
    }
}
