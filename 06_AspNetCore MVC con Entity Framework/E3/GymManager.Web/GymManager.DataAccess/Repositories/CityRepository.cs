using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess.Repositories
{
    public class CityRepository : Repository<int, City>
    {
        public CityRepository(GymManagerContext context) : base(context)
        {

        }
    }
}
