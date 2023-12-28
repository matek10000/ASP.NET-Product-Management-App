using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Projekt___produkty.Models;
using Xunit;

namespace ProductModelTests
{
    public class TestyModeluProduktu
    {
        [Fact]
        public void Produkt_Nazwa_Wymagana()
        {
            var produkt = new Product();
            var wynikiWalidacji = WalidujModel(produkt);

            Assert.Contains(wynikiWalidacji, vr => vr.MemberNames.Contains(nameof(Product.Name)));
            Assert.Contains(wynikiWalidacji, vr => vr.ErrorMessage == "SprawdŸ poprawnoœæ nazwy produktu!");
        }

        [Fact]
        public void Produkt_Nazwa_MaksDlugosc100()
        {
            var produkt = new Product
            {
                Name = new string('A', 101) // Przekracza maksymaln¹ d³ugoœæ
            };

            var wynikiWalidacji = WalidujModel(produkt);

            Assert.Contains(wynikiWalidacji, vr => vr.MemberNames.Contains(nameof(Product.Name)));
            Assert.Contains(wynikiWalidacji, vr => vr.ErrorMessage == "Nazwa produktu jest za d³uga!");
        }

        [Fact]
        public void Produkt_Producent_Wymagany()
        {
            var produkt = new Product();
            var wynikiWalidacji = WalidujModel(produkt);

            Assert.Contains(wynikiWalidacji, vr => vr.MemberNames.Contains(nameof(Product.Manufacturer)));
            Assert.Contains(wynikiWalidacji, vr => vr.ErrorMessage == "SprawdŸ poprawnoœæ producenta!");
        }

        [Fact]
        public void Produkt_Opis_Wymagany()
        {
            var produkt = new Product();
            var wynikiWalidacji = WalidujModel(produkt);

            Assert.Contains(wynikiWalidacji, vr => vr.MemberNames.Contains(nameof(Product.Description)));
            Assert.Contains(wynikiWalidacji, vr => vr.ErrorMessage == "SprawdŸ poprawnoœæ opisu produktu!");
        }

        private static List<ValidationResult> WalidujModel(object model)
        {
            var wynikiWalidacji = new List<ValidationResult>();
            var kontekstWalidacji = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, kontekstWalidacji, wynikiWalidacji, validateAllProperties: true);
            return wynikiWalidacji;
        }
    }
}
