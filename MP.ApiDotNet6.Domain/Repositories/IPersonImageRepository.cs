using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Domain.Repositories {
    public interface IPersonImageRepository {

        Task<PersonImage?> CreateAsync(PersonImage personImage);
        Task<PersonImage?> GetByIdAsync(int id);
        Task<ICollection<PersonImage>> GetByPersonIdAsync(int personId);
        Task EditAsync(PersonImage personImage);
    }
}
