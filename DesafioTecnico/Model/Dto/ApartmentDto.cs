using DesafioTecnico.Model.Entities;

namespace DesafioTecnico.Model.Dto
{
    public class ApartmentDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int BlockId { get; set; }
    }
}
