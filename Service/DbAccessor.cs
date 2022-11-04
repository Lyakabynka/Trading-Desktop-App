using EntityFramework_Exam.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Exam.Service
{
    static public class DbAccessor
    {
        static private ApplicationDbContext dbContext;
        static DbAccessor()
        {
            dbContext = new ApplicationDbContext();
        }



        static public void AddUser(User user)
        {
            dbContext.Users.Add(user);
        }



        static public User? GetUserByUsernameAndPassword(string username, string password)
        {
            return dbContext.Users
                    .Where(u => u.Username == username && u.Password == password)
                    .Include(u => u.Town)
                    .FirstOrDefault();
        }
        static public User? GetUserAndTownById(int userId)
        {
            return dbContext
                .Users
                .Where(u => u.Id == userId)
                .Include(u => u.Town)
                .FirstOrDefault();
        }



        static public IQueryable<User> GetAllUsersInUsersTown(User user)
        {
            return
                dbContext.Users
                .Where(u => u.Town.Id == user.TownId && u.Id != user.Id);
        }




        static public ICollection<Item> GetItemsByUserId(int userId)
        {
            return dbContext.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Items)
                .ThenInclude(I => I.ItemType)
                .First()
                .Items;
        }

        static public ICollection<Property> GetPropertiesByUserId(int userId)
        {
            return dbContext.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Properties)
                .ThenInclude(P => P.PropertyType)
                .First()
                .Properties;
        }



        static public DbSet<Town> GetAllTowns()
        {
            return dbContext.Towns;
        }



        static public bool ExistsUser(string username)
        {
            if (dbContext
                .Users
                .Where(u => u.Username == username)
                .FirstOrDefault() != null)
            {
                return true;
            }

            return false;
        }
        static public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

    }
}
