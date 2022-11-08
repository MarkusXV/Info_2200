using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_JellyBelly
{
  [Table("JellyBellyTable")] 
 
  ///Formats the table with columns using C# code that translates to SQL
  public class JellyBelly
  {
    [Key]
    public int JellyBellyId { get; set; } //JellyBellyId is the first column and the key

    [StringLength(30)]
    public string jellyBellyFlavor { get; set; } //Jellybellyflavor is the flavor up to 30 char.

    [StringLength(30)]
    public string category { get; set; } //Category is the category of flavor up to 30 char.
  }
}
