using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Domain.Repositories {
    public interface IPersonRepository {

        Task<Person> CreateAsync(Person person);
        
        Task<Person> GetByIdAsync(int id);

        Task<ICollection<Person>> GetPeopleAsync();

        Task EditAsync(Person person);

        Task DeleteAsync(Person person);

        Task<int> GetIdByDocumentAsync(string document);
    }
}
