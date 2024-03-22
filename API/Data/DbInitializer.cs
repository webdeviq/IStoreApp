using API.Models;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any())
            {
                return;
            }
            // Different brands = Angular, React, NetCore, TypeScript.

            List<Product> products = new()
            {
                new Product
                {
                    Title = "Laptop Angular",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 25000,
                    PictureUrl = "/images/products/laptopAngular.jpg",
                    Brand = "Angular",
                    Type = "Laptop",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Laptop React",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 30000,
                    PictureUrl = "/images/products/laptopReact.jpg",
                    Brand = "React",
                    Type = "Laptop",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Laptop NetCore",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 30000,
                    PictureUrl = "/images/products/laptopNetCore.jpg",
                    Brand = "NetCore",
                    Type = "Laptop",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Laptop Typescript",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 23000,
                    PictureUrl = "/images/products/laptopTypescript.jpg",
                    Brand = "Typescript",
                    Type = "Laptop",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Mobile Angular",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 12000,
                    PictureUrl = "/images/products/mobileAngular.jpg",
                    Brand = "Angular",
                    Type = "Mobile",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Mobile React",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 15000,
                    PictureUrl = "/images/products/mobileReact.jpg",
                    Brand = "React",
                    Type = "Mobile",
                    Quantity = 100,
                },
                new Product
                {
                                        Title = "Mobile NetCore",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 19000,
                    PictureUrl = "/images/products/mobileNetCore.jpg",
                    Brand = "NetCore",
                    Type = "Mobile",
                    Quantity = 100,
                },
                new Product
                {
                                        Title = "Mobile Typescript",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 17000,
                    PictureUrl = "/images/products/mobileTypescript.jpg",
                    Brand = "Typescript",
                    Type = "Mobile",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Speaker Angular",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 12000,
                    PictureUrl = "/images/products/speakerAngular.jpg",
                    Brand = "Angular",
                    Type = "Speaker",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Speaker React",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 18000,
                    PictureUrl = "/images/products/speakerReact.jpg",
                    Brand = "React",
                    Type = "Speaker",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Speaker NetCore",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 16000,
                    PictureUrl = "/images/products/speakerNetCore.jpg",
                    Brand = "NetCore",
                    Type = "Speaker",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Speaker Typescript",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 12000,
                    PictureUrl = "/images/products/speakerTypescript.jpg",
                    Brand = "Typescript",
                    Type = "Speaker",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Tablet Angular",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 12000,
                    PictureUrl = "/images/products/tabletAngular.jpg",
                    Brand = "Angular",
                    Type = "Tablet",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Tablet React",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 12000,
                    PictureUrl = "/images/products/tabletReact.jpg",
                    Brand = "React",
                    Type = "Tablet",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Tablet NetCore",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 12000,
                    PictureUrl = "/images/products/tabletNetCore.jpg",
                    Brand = "NetCore",
                    Type = "Tablet",
                    Quantity = 100,
                },
                new Product
                {
                    Title = "Tablet Typescript",
                    Description = "Cras a purus mollis, vehicula neque ac, pretium velit. Integer pulvinar non nunc ut hendrerit. Morbi vel arcu cursus, semper dolor a, viverra ex. Vestibulum ligula felis, faucibus quis faucibus id, dapibus non ipsum. Mauris molestie sed sem quis pellentesque. Sed ut dolor lectus. Donec sapien purus, facilisis at congue condimentum, lacinia ut massa.",
                    Price = 12000,
                    PictureUrl = "/images/products/tabletTypescript.jpg",
                    Brand = "Typescript",
                    Type = "Tablet",
                    Quantity = 100,
                }
            };
            // Looping over the products and adding to the db.
            foreach (Product product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}