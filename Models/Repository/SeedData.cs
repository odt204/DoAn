using Microsoft.EntityFrameworkCore;

namespace WebTrangSuc.Models.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
			if (!_context.Products.Any())
            {
                CategoryModel apple = new CategoryModel {Name="Apple",Slug="apple",Description="Apple is Large Brand in the world",Status= 1};
                CategoryModel samsung = new CategoryModel {Name= "samsung", Slug= "samsung", Description= "samsung is Large Brand in the world", Status=1};
                BrandModel dell = new BrandModel { Name = "dell", Slug = "dell", Description = "dell is Large Brand in the world", Status = 1 };
                BrandModel sony = new BrandModel { Name = "sony", Slug = "sony", Description = "sony is Large Brand in the world", Status = 1 };


                _context.Products.AddRange(
                     new ProductModel { Name = "macbook", Slug = "macbook", Description = "macbook is Best", Image = "1.jpg", Category = samsung, Brand = dell, Price = 1234 },
                    new ProductModel { Name = "pc", Slug = "pc", Description = "pc is Best", Image = "1.jpg", Category = samsung, Brand = sony, Price = 1234 }
                    );
                _context.SaveChanges();
			}
        }
    }
}
