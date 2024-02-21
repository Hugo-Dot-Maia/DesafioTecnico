namespace DesafioTecnico.Model.Entities
{
    public class Resident
    {
        public int Id { get; set; }
        
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public int ApartmentId { get; set; }
    }
}
