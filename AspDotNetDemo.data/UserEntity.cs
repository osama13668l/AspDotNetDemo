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
            new User(){ Id=1, FirstName="safaa", LastName ="jassim", Password="12345", Email = "o@mail.com"}
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
                Bio = table.Bio,
                Email = table.Email,
                FirstName = table.FirstName,
                LastName = table.LastName,
                Password = table.Password,
                Phone = table.Phone
            };

        }

        public User Find(int Id)
        {
            return ListOfUser.Where(X => X.Id == Id).First();
        }

        public List<User> GetData()
        {
            return ListOfUser;
        }

        public List<User> Seach(string SearchItem)
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
