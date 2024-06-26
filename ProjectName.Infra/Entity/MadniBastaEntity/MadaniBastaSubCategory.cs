﻿using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.MadaniBastaEntity
{
  public class MadaniBastaSubCategory : BaseEntity
  {
    [ForeignKey(nameof(MadaniBasta))]
    public int MadaniBastaId { get; set; }
    public virtual MadaniBasta? MadaniBasta { get; set; }

  }
}
