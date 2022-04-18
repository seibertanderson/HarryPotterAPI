using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAppService<T> where T : class
    {
        public List<T> GetAll();
        public T GetById(int id);
    }
}
