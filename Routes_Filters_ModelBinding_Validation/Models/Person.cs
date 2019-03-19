using System;
using System.Collections.Generic;

namespace Routes_Filters_ModelBinding_Validation.Models
{
  public class Person
  {
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public Address HomeAddress { get; set; }
    public bool IsApproved { get; set; }
    public Role Role { get; set; }
    public Pet Pet { get; set; }
  }
    
  public class Pet
  {
      public int PetId { get; set; }
      public string Species { get; set; }
      public string PetName { get; set; }
      public ICollection<string> Nicknames { get; set; }
    }
  public class Address
  {
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
  }

  public enum Role
  {
    Admin,
    User,
    Guest
  }
}