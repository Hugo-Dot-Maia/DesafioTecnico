namespace DesafioTecnico.Model.Entities
{
    public class Block
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CondominiumId { get; set; }
        public Condominium Condominium { get; set; }
        public List<Apartment> Apartments { get; set; }
    }
}
