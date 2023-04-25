namespace ProjectName.Infra.Entity.Base
{
    public abstract class BaseEntity
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        //public virtual IList<Hotel> Hotels { get; set; } // This Property Nothing to do with db it just if you want to access the Child will be handle through this property
    }
}
