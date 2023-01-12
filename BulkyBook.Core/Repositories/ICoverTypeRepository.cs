using BulkyBook.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Core.Repositories
{
    public interface ICoverTypeRepository : IGenericRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
