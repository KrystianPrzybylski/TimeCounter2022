using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCounter2022.Repository
{
    using TimeCounter2022.Entities;
    internal class GenericRepository<T> where T:IEntity
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Save()
        { }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
    }
}
