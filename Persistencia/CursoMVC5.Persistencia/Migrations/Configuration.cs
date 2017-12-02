namespace CursoMVC5.Persistencia.Migrations
{
    using CursoMVC5.Persistencia.Entidades;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CursoMVC5.Persistencia.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CursoMVC5.Persistencia.Contexto context)
        {   
            if (context.
                Categorias.
                ToList().Count ==0)
            context.Categorias.Add(new Categoria { Nome = "Eletrônicos" });
        }
    }
}
