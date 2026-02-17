using Microsoft.EntityFrameworkCore;
using MvcFriends.Models; // 確保有引用 Friend 類別所在的資料夾

namespace MvcFriends.Data
{
    public class FriendContext : DbContext
    {
        // 1. 建構子：只需負責把 options 傳給父類別 (base)
        public FriendContext(DbContextOptions<FriendContext> options) : base(options)
        {
            // 這裡通常是空的
        }

        // 2. 屬性：必須放在建構子外面，這代表資料庫裡的資料表
        public DbSet<Friend> Friends { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().HasData(
                new Friend { Id = 1, Name = "Mary", Email = "mary@gmail.com", Mobile = "0912312312" },
                new Friend { Id = 2, Name = "David", Email = "david@gmail.com", Mobile = "0945456456" },
                new Friend { Id = 3, Name = "Jacob", Email = "jacob@gmail.com", Mobile = "0978789789" }
            );

        }
    }
}