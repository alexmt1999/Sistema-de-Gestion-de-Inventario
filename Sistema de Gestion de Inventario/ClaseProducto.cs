using System;
using System.ComponentModel.DataAnnotations;

public class Producto
{

    public Producto()
    {
        fechaRegistro = DateTime.Now; //asignamos la hora actual a fechaRegistro
    }

	private int id;

	private string name;

	private decimal price;

	private int stock;

    private DateTime fechaRegistro;


    public int Id { get => id; set => id = value; }

    [Required] [MaxLength(100)]
    public string Name { get => name; set => name = value; }

    public decimal Price { get => price; set => price = value; }

    public int Stock { get => stock; set => stock = value; }

    public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; } 
}
