using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agenda_Telefonica.Models;

namespace Agenda_Telefonica.Data
{
    public class Agenda_TelefonicaContext : DbContext
    {
        public Agenda_TelefonicaContext (DbContextOptions<Agenda_TelefonicaContext> options): base(options)
        {
        }

        public DbSet<Contatos> Contatos { get; set; }
    }
}
