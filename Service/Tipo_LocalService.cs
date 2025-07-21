using Domain;
using Persistense.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Tipo_LocalService : ITipo_LocalService
    {
        private readonly IDatabaseConn _databaseConn;

        public Tipo_LocalService(IDatabaseConn conn)
        {
            _databaseConn = conn;   
        }

        public List<Tipo_local> GetAll() => (List<Tipo_local>)_databaseConn.Query<Tipo_local>("SELECT * FROM tipo_local");

        public void Add(string nome) => _databaseConn.Query("INSERT INTO tipo_local (nome) VALUES (@nome)", new { nome });

        public void Remove(string id) => _databaseConn.Query("DELETE FROM tipo_local WHERE id = @id", new { id });

        public void Update(string nome, string id) => _databaseConn.Query("UPDATE tipo_local SET nome = @nome WHERE id = @id",new { nome, id });
    }
}
