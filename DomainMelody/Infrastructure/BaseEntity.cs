using System;

namespace Models.Infrastructure
{
    public abstract class BaseEntity : object
    {
        public BaseEntity() : base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }


    }
}
