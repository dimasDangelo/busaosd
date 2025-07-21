using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ILocalService
    {
        public void  add(Locais local);
        public void update(Locais local);
        public void remove(string id);
        public List<Locais> getAll();
    }
}
