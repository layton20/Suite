using Suite.Models;

namespace Suite.Manager
{
    public interface ITagManager
    {
        Task<bool> AddAsync(string name);
        Task<bool> DeleteAsync(Guid tagUid);
        Task<List<TagModel>> GetTags();
        Task<TagModel> GetTag(Guid uid);
    }
}
