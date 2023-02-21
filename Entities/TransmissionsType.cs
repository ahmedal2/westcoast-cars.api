namespace westcoast_cars.api.Entities
{
    public class TransmissionsType : BaseEntity
    {

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}