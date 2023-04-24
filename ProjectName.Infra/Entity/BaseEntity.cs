﻿
namespace ProjectName.Infra.Entity
{
  public abstract class BaseEntity
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? CreatedAt { get; set; }
    public string? UpdatedAt { get; set; }
    //public virtual IList<Hotel> Hotels { get; set; } // This Property Nothing to do with db it just if you want to access the Child will be handle through this property
  }
}
