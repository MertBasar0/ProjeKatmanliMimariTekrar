using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO_s
{
    public class CategoryDetailDto : IDto
    {
        public string CategoryName { get; set; }


        public string ProductName { get; set; }


        public int UnitsInStock { get; set; }


        public int UnitsInOrder { get; set; }
    }
}
