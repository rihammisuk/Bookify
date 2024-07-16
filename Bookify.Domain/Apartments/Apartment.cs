﻿using Bookify.Domain.Abstructions;

namespace Bookify.Domain.Apartments
{
    public sealed class Apartment : Entity
    {
        public Apartment(Guid id,
            Name name,
            Description description,
            Address address,
            Money price,
            Money cleaningFee,
            DateTime? lastBookOnUtc,
            List<Amenity> amenities) : base(id)
        {
            Name = name;
            Description = description;
            Address = address;
            Price = price;
            CleaningFee = cleaningFee;
            LastBookOnUtc = lastBookOnUtc;
            Amenities = amenities;
        }

        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public Address Address { get; private set; }
        public Money Price { get; private set; }
        public Money CleaningFee { get; private set; }
        public DateTime? LastBookOnUtc { get; private set; }
        public List<Amenity> Amenities { get; private set; } = new();
    }
}
