using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class Product : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Autor { get; set; }
    public decimal Price { get; set; }

    public string GetBasicInfo()
    {
        throw new NotImplementedException();
    }
}
