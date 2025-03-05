using ConnPet.Core.Enums;
namespace ConnPet.Core.Models;

public class Consultation : ModelBase
{
  public string Reason { get; set; } = string.Empty;
  public ConstultationStatusEnum Status { get; set; }
  public string Diagnosis { get; set; } = string.Empty;
  public string Observation { get; set; } = string.Empty;
  public DateTime DateSchedule { get; set; }

  public long ClinicId { get; set; }
  public Clinic Clinic { get; set; } = null!;

  public long VetId { get; set; }
  public User Vet { get; set; } = null!;

  public long PetId { get; set; }
  public Pet Pet { get; set; } = null!;
}


