using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson34.ASP.NET_Core._MVC._WebAPI._REST
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
    }
}
