using AspDotNetDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspDotNetDemo.data
{
    public class UserEntity : IDataHelper<User>
    {
        List<User> ListOfUser;
        private User user;
        public UserEntity()
        {
            ListOfUser = new List<User>();
            ListOfUser = new List<User> {
                new User(){ Id=1, FirstName="Safaa", LastName ="Jassim", Password="12345", Email = "o@mail.com",Phone=123456789, Bio = "Osama"},
                new User(){ Id=2, FirstName="Ali", LastName ="Ahamd", Password="12345", Email = "o@mail.com",Phone=123456789, Bio = "Osama"},
                new User(){ Id=3, FirstName="kmal", LastName ="klin", Password="12345", Email = "o@mail.com",Phone=123456789, Bio = "Osama"},
                new User(){ Id=4, FirstName="zaid", LastName ="saad", Password="12345", Email = "o@mail.com",Phone=123456789, Bio = "Osama"},
            };
        }
        public void Add(User table)
        {
            ListOfUser.Add(table);
        }

        public void Delete(int Id)
        {
            user = Find(Id);
            ListOfUser.Remove(user);
        }

        public void Edit(int Id, User table)
        {
            user = Find(Id);
            user = new User()
            {
                Id = table.Id,
                Bio = table.Bio,
                Email = table.Email,
                FirstName = table.FirstName,
                LastName = table.LastName,
                Password = table.Password,
                Phone = table.Phone
            };
            var index = ListOfUser.FindIndex(X => X.Id == Id);
            ListOfUser[index] = user;

        }

        public User Find(int Id)
        {
            if (Id > 0)
            {
                return ListOfUser.Where(X => X.Id == Id).First();
            }
            else
            {
                return null;
            }
        }

        public List<User> GetData()
        {
            return ListOfUser;
        }

        public List<User> Search(string SearchItem)
        {
            return ListOfUser.Where(X => X.Id.ToString() == SearchItem
            || X.FirstName.Contains(SearchItem)
            || X.LastName.Contains(SearchItem)
            || X.Email == SearchItem
            || X.Bio.Contains(SearchItem)
            || X.Password.Contains(SearchItem)
            || X.Phone.ToString() == SearchItem
            ).ToList();
        }
    }
}
