using EntityFramework_Exam.Model.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Exam.Model
{
    public class Item
    {
        [NotMapped]
        public bool IsChecked { get; set; } = false;



        public int Id { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }

        public int ItemTypeId {get;set;}
        public ItemType ItemType { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
