using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMart.com.IRepository
{
    public interface IExternalApi<T>
    {
         T GetProductInfo<T>();
    }
}
