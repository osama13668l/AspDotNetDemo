using System;
using System.Collections.Generic;
using System.Text;

namespace AspDotNetDemo.data
{
    public interface IDataHelper<Table>
    {
        List<Table> GetData();
        List<Table> Search(string SearchItem);

        Table Find(int Id);
        void Add(Table table);
        void Edit(int Id, Table table);
        void Delete(int Id);
    }
}
