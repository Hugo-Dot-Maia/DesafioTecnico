using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Model.Dto
{
    public class BlockDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CondominiumId { get; set; }
        public List<Apartment> Apartments { get; set; }
    }
}
