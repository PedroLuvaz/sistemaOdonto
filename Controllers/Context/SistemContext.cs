using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Controllers.Map;

namespace Controllers.Context
{
    class SistemContext : DbContext
    {
        public SistemContext() : base("Server=PEDRO\\SQLEXPRESS; Database=odonto; Integrated Security=True;")
        {
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
