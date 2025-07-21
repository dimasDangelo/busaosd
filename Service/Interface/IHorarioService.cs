using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IHorarioService
    {
        public void add(Horarios_onibus horarios);
        public void update(Horarios_onibus  horarios);
        public void delete(string id);
        public List<Horarios_onibus> GetAll();
    }
}
