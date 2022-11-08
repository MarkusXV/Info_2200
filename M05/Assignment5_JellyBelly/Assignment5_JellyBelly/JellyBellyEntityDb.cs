using System;
using System.Data.Entity;
using System.Linq;

namespace Assignment5_JellyBelly
{
  public class JellyBellyEntityDb : DbContext
  {
    
    public JellyBellyEntityDb() 
        : base("name=JellyBellyEntityDb")
    {
    }

    public DbSet<JellyBelly> JellyBellies { get; set; } //Creates a table in the database called JellyBellies

    
  }

  
}