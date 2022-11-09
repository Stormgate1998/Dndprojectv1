using Dndprojectv1.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class DNDDbContext : IdentityDbContext
{
    public DNDDbContext(DbContextOptions<DNDDbContext> options)
           : base(options)
    {
        DbSet<UserCharacterInfo> userCharacterInfos;
    }
}