﻿using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<product> Products = new List<product>
        {
            new product
            {
                Id = "1",
                Name = "IPhone X",
                Description = "This phone is the company’s biggest change to its flagship smartphone in years.",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new product
            {
                Id = "2",
                Name = "Samsung 10",
                Description = "This phone is the company’s biggest change to its flagship smartphone in years.",
                ImageFile = "product-2.png",
                Price = 840.00M,
                Category = "Smart Phone"
            },
            new product
            {
                Id = "3",
                Name = "Huawei Plus",
                Description = "This phone is the company’s biggest change to its flagship smartphone in years.",
                ImageFile = "product-3.png",
                Price = 650.00M,
                Category = "White Appliances"
            },
            new product
            {
                Id = "4",
                Name = "Xiaomi Mi 9",
                Description = "This phone is the company’s biggest change to its flagship smartphone in years.",
                ImageFile = "product-4.png",
                Price = 470.00M,
                Category = "White Appliances"
            },
            new product
            {
                Id = "5",
                Name = "HTC U11+ Plus",
                Description = "This phone is the company’s biggest change to its flagship smartphone in years.",
                ImageFile = "product-5.png",
                Price = 380.00M,
                Category = "Smart Phone"
            },
            new product
            {
                Id = "6",
                Name = "LG G7 ThinQ New8",
                Description = "This phone is the company’s biggest change to its flagship smartphone in years.",
                ImageFile = "product-6.png",
                Price = 240.00M,
                Category = "Home Kitchen"
            }
        };
    }
}
