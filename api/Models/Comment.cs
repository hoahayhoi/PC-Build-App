using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace api.Models
{
    [Table("Comment")] 

    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreateOn { get; set; } = DateTime.Now;

        public int? StockId { get; set; }

        // For Navigation 
        public Stock? Stock { get; set; }
    }
}