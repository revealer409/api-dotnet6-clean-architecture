using MP.ApiDotNet6.Domain.Validations;

namespace MP.ApiDotNet6.Domain.Entities {
    public class PersonImage {
       

        public int Id { get; set; }

        public string? ImageUri { get; set; }
        public string? ImageBase { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public PersonImage(string? imageUri, string? imageBase, int personId) {
            Validation(personId);
            ImageUri = imageUri;
            ImageBase = imageBase;
        }

        private void Validation(int personId) {
            DomainValidationException.When(personId == 0, "Id pessoa deve ser informado"); 
            PersonId = personId;
        }
    }
}
