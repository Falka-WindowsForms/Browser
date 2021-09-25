using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addr { get; set; }
        public int CategoryId { get; set; }
    }
}
