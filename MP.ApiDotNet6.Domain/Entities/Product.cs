using MP.ApiDotNet6.Domain.Validations;
using System;

namespace MP.ApiDotNet6.Domain.Entities {
    public class Product {


        public int Id { get; private set; }

        public string Name { get; private set; }

        public string CodErp { get; private set; }

        public decimal Price { get; private set; }

        public ICollection<Purchase> Purchases { get; set; }

        public Product(string name, string codErp, decimal price) {
            Validation(name, codErp, price);
        }

        public Product(int id, string name, string codErp, decimal price) {
            DomainValidationException.When(id < 0, "Id do produto deve ser informado");
            Id = id;
            Validation(name, codErp, price);
        }

        private void Validation(string name, string codErp, decimal price) {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(codErp), "Código ERP deve ser informado");
            DomainValidationException.When(price < 0, "Preço ERP deve ser informado");

            Name = name;
            CodErp = codErp;
            Price = price;
        }
    }
}
