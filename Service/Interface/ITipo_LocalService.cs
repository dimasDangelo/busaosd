using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITipo_LocalService
    {
        public void Add(string nome);

        public void Remove(string id);

        public void Update(string nome, string id);
        
        public List<Tipo_local> GetAll();
    }
}
