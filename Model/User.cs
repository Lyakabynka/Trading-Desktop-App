using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Exam.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        
        public int TownId { get; set; }
        public Town Town { get; set; }


        public ICollection<Trade> SaleTrades { get; set; }
        public ICollection<Trade> PurschaseTrades { get; set; }


        public ICollection<Property>? Properties { get; set; }
        public ICollection<Item> Items { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(string username, string password, Town town)
        {
            Username = username;
            Password = password;
            Town = town;
        }
        public User(int id, string username, string password, Town town, ICollection<Trade> saleTrades, ICollection<Trade> purschaseTrades, ICollection<Property>? property, ICollection<Item> items)
        {
            Id = id;
            Username = username;
            Password = password;
            Town = town;
            SaleTrades = saleTrades;
            PurschaseTrades = purschaseTrades;
            Properties = property;
            Items = items;
        }

        public override string ToString()
        {
            return $"User Id: {Id} | Username: {Username} | Town: ( {Town} )";
        }
    }
}
