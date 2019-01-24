namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBase : DbContext
    {
        // Your context has been configured to use a 'DBase' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.DBase' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBase' 
        // connection string in the application configuration file.
        public DBase()
            : base("name=DBase")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
    }
    public class StoreDbInitializer : DropCreateDatabaseAlways<DBase>
    {
        protected override void Seed(DBase db)
        {
            db.Users.Add(new User() { BirthDate = "10-10-1998", Card = null, Email = "root@root.com", FName = "GG", Gender = false, LName = "LOX", orders = null, Password="1" });
            db.Flights.Add(new Flight() { Count=1, Date=DateTime.Now, From = "Rivne", ID=1, Plen="1337-228", To="Kyiv", PriceBussines=1, PriceEconom=1, PriceStandart=1 });
            db.Flights.Add(new Flight() { Count = 1, Date = DateTime.Now, From = "Rivne", ID = 1, Plen = "1337-228", To = "Londom", PriceBussines = 100, PriceEconom = 110, PriceStandart = 120 });

            db.SaveChanges();
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}