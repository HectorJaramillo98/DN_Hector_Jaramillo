using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public interface IColorsDataManager
    {
        public void Insert(Color color);
        public void Update(Color color);

        Color Get(int id);

        public IList<Color> GetAll();

        public void Delete(int id);

        
    }
}
