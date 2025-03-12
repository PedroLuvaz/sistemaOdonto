using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Controllers.Map;
using Entidades;

namespace Controllers.Context
{
    class SistemContext : DbContext
    {
        //PASSO A PASSO PARA CONFIGURAÇÃO EM DIFERENTES PCS
        //ENABLE-MIGRATIONS
        //ADD-MIGRATION BANCO
        //UPDATE-DATABASE

        //PARA ATUALIZAÇÃO DE NOVOS CAMPOS EM ENTIDADES JÁ EXISTENTES REFAZER O PASSO A PASSO ACIMA.

        // Construtor que define a string de conexão com o banco de dados
        public SistemContext() : base("Server=PEDRO\\SQLEXPRESS01; Database=odonto; Integrated Security=True;")
        {

        }

        // Propriedades que representam as tabelas do banco de dados
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }

        // Método que configura o mapeamento das entidades
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desabilita a inicialização do banco de dados
            Database.SetInitializer<SistemContext>(null);

            // Adiciona as configurações de mapeamento das entidades
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());

            // Chama o método base para completar a configuração
            base.OnModelCreating(modelBuilder);
        }
    }
}
