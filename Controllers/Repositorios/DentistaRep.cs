using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class DentistaRep
    {
        public void Cadastrar(Dentista obj)
        {
            using (var ctx = new SistemContext())
            {
                ctx.Dentistas.Add(obj);
                ctx.SaveChanges();
            }
        }

        public Dentista Buscar(int id)
        {
            Dentista obj = new Dentista();
            using (var ctx = new SistemContext())
            {
                obj = ctx.Dentistas.Find(id);
            }

            return obj;
        }

        public List<Dentista> Listar()
        {
            using (var ctx = new SistemContext())
            {
                var Dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Nome).ToList();
            return Dentistas;
            }

        }
        public void Atualizar(Dentista objNew)
        {
            using (var ctx = new SistemContext())
            {
                Dentista objOld = ctx.Dentistas.Find(objNew.Id);
                objOld.Nome = objNew.Nome;
                objOld.Telefone = objNew.Telefone;
                objOld.Celular = objNew.Celular;
                objOld.CRO = objNew.CRO;
                objOld.Email = objNew.Email;
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new SistemContext())
            {
               Dentista obj = ctx.Dentistas.Find(id);
               ctx.Dentistas.Remove(obj);
                ctx.SaveChanges();
            }
        }
    }
}
