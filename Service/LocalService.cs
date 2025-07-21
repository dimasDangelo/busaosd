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
    public class LocalService : ILocalService
    {
        private readonly IDatabaseConn _databaseConn;
        public LocalService(IDatabaseConn database)
        {
            _databaseConn = database;
        }
        public void  add(Locais local) => _databaseConn.Query("INSERT INTO locais (nome, id_tipo_local) VALUES (@nome, @id_tipo_local)",
            new {local.nome, local.id_tipo_local});

        public List<Locais> getAll() =>   _databaseConn.Query<Locais>("SELECT * FROM locais").ToList();
        

        public void remove(string id) => 
            _databaseConn.Query("DELETE FROM locais WHERE id = @id", new { id });

        public void update(Locais local) => 
            _databaseConn.Query("UPDATE locais SET nome = @nome, id_tipo_local = @id_tipo_local WHERE id = @id",
            new { local.nome, local.id_tipo_local, id = local.id });
    }
}
