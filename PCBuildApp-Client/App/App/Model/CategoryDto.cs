using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class CategoryDto
    {
        public CategoryDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public CategoryDto()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
