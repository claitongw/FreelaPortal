using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)//chama o construtor da base do DbContext que está sendo erdado na linha 8
        {

            #region commented
            //Projects = new List<Project>
            //{
            //    new Project("Meu projeto ASPNET Core 1", "Minha Descricao de Projeto 1", 1, 1, 10000),
            //    new Project("Meu projeto ASPNET Core 2", "Minha Descricao de Projeto 2 ", 1, 1, 20000),
            //    new Project("Meu projeto ASPNET Core 3", "Minha Descricao de Projeto 3 ", 1, 1, 30000)
            //};

            //Users = new List<User>
            //{
            //    new User("Luis Felipe", "luisdev@luisdev.com.br", new DateTime(1992, 1, 1)),
            //    new User("Robert C Martin", "robert@luisdev.com.br", new DateTime(1950, 1, 1)),
            //    new User("Anderson", "anderson@luisdev.com.br", new DateTime(1980, 1, 1)),
            //};

            //Skills = new List<Skill>
            //{
            //    new Skill(".NET Core"),
            //    new Skill("C#"),
            //    new Skill("SQL")
            //};
            #endregion
        }
        #region commented
        //public List<Project> Projects { get; set; }
        //public List<User> Users { get; set; }
        //public List<Skill> Skills { get; set; }
        //public List<ProjectComment> ProjectComments { get; set; }
        #endregion
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkill { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}