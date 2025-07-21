using Service.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistense.Interface;

namespace Service
{
    public class HorarioService : IHorarioService
    {
        private readonly IDatabaseConn _databaseConn;
        public HorarioService(IDatabaseConn database)
        {
            _databaseConn = database;
        }
        public List<Horarios_onibus> GetAll() => _databaseConn.Query<Horarios_onibus>(@"SELECT * FROM `horarios_onibus`").ToList();
        // implementar metodo no databaseConn para montar insert apenas inserindo a classe em questão 
        public void add(Horarios_onibus horarios) => 
          _databaseConn.Query(@"INSERT INTO `horarios_onibus` 
            (`origem_id`, `destino_id`, `horario`, `seg`, `ter`, `qua`, `qui`, `sex`, `sab`, `dom`, `feriado`)
            VALUES (@origem, @destino, @horario, @seg, @ter, @qua, @qui, @sex, @sab, @dom , @feriado);",
              new {horarios.origem, horarios.destino, horarios.horario, horarios.seg, horarios.ter, horarios.qua, horarios.qui, horarios.sex, horarios.sab, horarios.dom, horarios.feriado});

        public void delete(string id) => _databaseConn.Query(@"DELETE FROM `horarios_onibus` WHERE id = @id", new { id });

        public void update(Horarios_onibus horarios) =>
            _databaseConn.Query(@"UPDATE `horarios_onibus` SET 
            origem_id = @origem, 
            destino_id = @destino, 
            horario = @horario, 
            seg = @seg, 
            ter = @ter, 
            qua = @qua, 
            qui = @qui,
            sex = @sex
            sab = @sab,
            dom = @dom,
            feriado = @feriado 
            WHERE id = @id
            ", new { horarios.origem, horarios.destino, horarios.horario, horarios.seg, horarios.ter, horarios.qua, horarios.qui, horarios.sex, horarios.sab, horarios.dom, horarios.feriado });
    }
}
