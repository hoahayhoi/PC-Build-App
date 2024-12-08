using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class ComponentDto
    {
        public ComponentDto(string name, int categoryID, decimal price, int stock, int? supplierID, string image)
        {
            Name = name;
            CategoryID = categoryID;
            Price = price;
            Stock = stock;
            SupplierID = supplierID;
            Image = image;
        }

        public ComponentDto()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        public int? SupplierID { get; set; }

        public string Image {  get; set; }
    }
}
