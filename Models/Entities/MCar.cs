﻿namespace Car4EgarAPI.Models.Entities
{
    public class MCar
    {
        public string VIN { get; set; } //VIN
        public string Color { get; set; }
        public string LicenseNumber { get; set; }
        public int Seats { get; set; }
        public double Rate { get; set; }
        public int RatedPeople { get; set; }
        public double Mailage { get; set; }
        public string CarType { get; set; }
        public DateTime LicenseEXDate { get; set; }
        public int Year { get; set; }
        public bool AvailableForRent { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string LocationOfRent { get; set; }
        public double CostPerDay { get; set; }
        public string Image { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Insurance { get; set; }
        public string GearBoxType { get; set; }
        public bool IsActivated { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoto { get; set; }
        public string OwnerPhone { get; set; }
        //[JsonIgnore]
        //public virtual SystemUser Owner { get; set; }
        //[JsonIgnore]
        //public virtual Rent? Rent { get; set; }
    }
}
