// ConsoleApp2
// ConsoleApp2
// Address.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 3:43 22 11 2022

namespace ConsoleApp2
{
    public class Address
    {
        public string Country { get; set; } = "РФ";
        public string RegionName { get; set; } = "Псковская область";
        public int RegionCode { get; set; } = 60;
        public string District { get; set; } = "Псковский район";
        public string City { get; set; } = "Псков";
        public string Street { get; set; } = "ул. Гоголя";
        public string House { get; set; } = "18 б";
        public string Office { get; set; } = "15";
        public string PostalCode { get; set; } = "180000";
        public string CountryCode { get; set; } = "8";

        public override string ToString()
        {
            return $"PostalCode: {PostalCode}, " +
                   $"CountryCode: {CountryCode}, Country: {Country}, " +
                   $"RegionCode: {RegionCode}, RegionName: {RegionName}, " +
                   $"District: {District}, City: {City}, " +
                   $"Street: {Street} {House} {Office}";
        }
    }
}