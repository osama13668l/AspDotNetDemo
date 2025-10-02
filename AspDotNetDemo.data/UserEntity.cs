using AspDotNetDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspDotNetDemo.data
{
    public class UserEntity : IDataHelper<User>
    {
        List<User> ListOfUser;
        public UserEntity()
        {
            ListOfUser = new List<User>();

        }
        void IDataHelper<User>.Add(User table)
        {
            throw new NotImplementedException();
        }

        void IDataHelper<User>.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        void IDataHelper<User>.Edit(int Id, User table)
        {
            throw new NotImplementedException();
        }

        User IDataHelper<User>.Find(int Id)
        {
            throw new NotImplementedException();
        }

        List<User> IDataHelper<User>.GetData()
        {
            return ListOfUser;
        }

        List<User> IDataHelper<User>.Seach(string SearchItem)
        {
            return ListOfUser.Where(x => x.Id.ToString() == SearchItem
            || x.FirstName.Contains(SearchItem)
            || x.LastName.Contains(SearchItem)
            || x.Email == SearchItem
            || x.Bio.Contains(SearchItem)
            || x.Password.Contains(SearchItem)
            || x.Phone.ToString() == SearchItem
            ).ToList();
        }
    }
}
