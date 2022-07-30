using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeetrootWebApplication
{
    public class Storage<T>
    {
        private static Storage<T> _instance;
        private List<T> _data;
        public static Storage<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Storage<T>();
                }
                return _instance;
            }
        }

        private Storage()
        {
            _data = new List<T>();
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return _data;
        }

        public void Add(T item)
        {
            _data.Add(item);
        }

        public T Get(int index) => _data[index];
    }
}