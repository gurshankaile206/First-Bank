using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstBank.Models
{
  public class Banker : Person
  {
      [DataType(DataType.Date)]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      [Display(Name = "Hire Date")]
      public DateTime HireDate { get; set; }
      public virtual ICollection<BankAccount> BankAccounts { get; set; } 
  }
}