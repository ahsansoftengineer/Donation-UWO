using ProjectName.Domain.Enums;

namespace ProjectName.Infra.Entity.Base
{
  public abstract class BaseEntity : AlphaEntity
  {
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
  }
  public abstract class BaseStatusEntity : BaseEntity
  {
    //[NotMapped]
    public Status? Status { get; set; } // = Status.None;
  }
}
