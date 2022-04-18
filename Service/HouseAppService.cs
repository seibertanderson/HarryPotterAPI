using Infrastructure.Data;
using Infrastructure.Entities;

namespace Service
{
    public class HouseAppService : IAppService<House>
    {
        public List<House> GetAll()
        {
            return AllDataTemp.Houses;
        }

        public House GetById(int id)
        {
            var result = AllDataTemp.Houses.Where(h => h.Id == id).FirstOrDefault();
            return result;
        }
    }
}