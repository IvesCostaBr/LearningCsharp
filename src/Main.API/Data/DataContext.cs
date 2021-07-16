using Main.API.models;
using Microsoft.EntityFrameworkCore;

namespace Main.API.data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) :base(options){} //pega as configurações do banco 
        public DbSet<Eventos> Eventos { get; set; } //pega os campos do banco

        
    }
}