using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistense.Interface
{
    public interface IDatabaseConn
    {
        public  IEnumerable<T> Query<T>(string query, object parameters = null);

        public void Query(string query, object parameters = null);
    }
}
