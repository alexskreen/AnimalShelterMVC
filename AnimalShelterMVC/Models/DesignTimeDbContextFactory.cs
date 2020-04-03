// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Design;
// using Microsoft.Extensions.Configuration;
// using System.IO;

// namespace AnimalShelterMVC.Models
// {
//   public class AnimalShelterMVCContextFactory : IDesignTimeDbContextFactory<AnimalShelterMVCContext>
//   {

//     AnimalShelterMVCContext IDesignTimeDbContextFactory<AnimalShelterMVCContext>.CreateDbContext(string[] args)
//     {
//       IConfigurationRoot configuration = new ConfigurationBuilder()
//         .SetBasePath(Directory.GetCurrentDirectory())
//         .AddJsonFile("appsettings.json")
//         .Build();

//       var builder = new DbContextOptionsBuilder<AnimalShelterMVCContext>();
//       var connectionString = configuration.GetConnectionString("DefaultConnection");

//       builder.UseMySql(connectionString);

//       return new AnimalShelterMVCContext(builder.Options);
//     }
//   }
// }