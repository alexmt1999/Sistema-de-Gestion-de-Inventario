using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

public class InventarioContext : DbContext // La clase hereda de DbContext, lo que la convierte en un contexto de EF Core
{
	public DbSet<Producto> Productos { get; set; } // Le dice a EF que quieres una tabla llamada Productos basada en tu clase Producto

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Aquí defines cómo conectarte a la base de datos (con UseSqlServer(...))

        optionsBuilder.UseSqlServer("localhost=DESKTOP-04LRB7V\\ALEJANDROGESTION;" +
            "DataBase=AlejandroDataBase;Trusted_Connection=True;Encrypt=False;");

        
    }
    
}
