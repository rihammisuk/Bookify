﻿namespace Bookify.Domain.Abstructions
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; init; }
    }
}
