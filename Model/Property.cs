using EntityFramework_Exam.Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Exam.Model
{
    public class Property
    {
        
        public int Id { get; set; }
        public string Description { get; set; }

        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

    }
}
