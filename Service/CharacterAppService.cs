using Infrastructure.Data;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CharacterAppService : IAppService<Character>
    {
        public List<Character> GetAll()
        {
            return AllDataTemp.Characters;

        }

        public Character GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
