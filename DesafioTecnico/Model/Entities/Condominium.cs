namespace DesafioTecnico.Model.Entities
{
    public class Condominium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SyndicName { get; set; }
        public List<Block> Blocks { get; set; }
    }
}
