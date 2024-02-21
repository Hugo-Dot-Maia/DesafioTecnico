
using System.ComponentModel.DataAnnotations;

namespace DesafioTecnico.Model.Dto
{
    public class ResidentDto
    {

        public string FullName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int ApartmentId { get; set; }
    }
}
