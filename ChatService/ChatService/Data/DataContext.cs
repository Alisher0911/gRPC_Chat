using System;
using ChatService.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatService.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}
