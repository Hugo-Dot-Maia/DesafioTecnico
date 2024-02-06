namespace DesafioTecnico.Model.Entities
{
    public class Apartment
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int BlockId { get; set; }
        public Block Block { get; set; }
        public List<Resident> Residents { get; set; }
    }
}
