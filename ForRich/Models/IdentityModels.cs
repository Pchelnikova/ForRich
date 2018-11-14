using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using ForRich.Models.DBModels;
using ForRich.Models.DBModels.Types_of_Budjet;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ForRich.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class AppUser : IdentityUser
    {
        public int Age { get; set; }    
        public virtual Family Family { get; set; }
        public string Name { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<AppDbContext>(new MyInitializer<AppDbContext>());
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }       
        public virtual DbSet<Wish> Wish_Lists { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<Profit> Profits { get; set; }
        public virtual DbSet<Expence> Expences { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Profit_Type> Profit_Types { get; set; }
        public virtual DbSet<Expence_Type> Expances_Types { get; set; }
        public virtual DbSet<Event_Type> Event_Types { get; set; }             
    }
}