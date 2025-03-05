namespace ConnPet.Core.Models;

public class Tutor : ModelBase
{
  public string Name { get; set; } = string.Empty;
  public string Document { get; set; } = string.Empty;

  public long? AddressId { get; set; }
  public Address Address { get; set; } = null!;
  public ICollection<Pet>? Pets { get; set; }
}