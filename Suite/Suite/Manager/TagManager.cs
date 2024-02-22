using Microsoft.EntityFrameworkCore;
using Suite.Data;
using Suite.Models;

namespace Suite.Manager
{
    public class TagManager : ITagManager
    {
        private readonly SuiteContext __Context;

        public TagManager(SuiteContext context) => __Context = context;

        public async Task<bool> AddAsync(string name)
        {
            __Context.Tag.Add(new TagModel(name));
            int _Changes = await __Context.SaveChangesAsync();

            return _Changes > 0;
        }

        public async Task<bool> DeleteAsync(Guid tagUid)
        {
            if (tagUid == Guid.Empty)
            {
                return false;
            }
            
            TagModel? _Tag = await __Context.Tag.FindAsync(tagUid);
            
            if (_Tag == null)
            {
                return false;
            }
            
            __Context.Tag.Remove(_Tag);
            int _Changes = await __Context.SaveChangesAsync();
            
            return _Changes > 0;
        }

        public async Task<List<TagModel>> GetTags() => await __Context.Tag.ToListAsync();
        
        public async Task<TagModel> GetTag(Guid uid)
        {
            if (uid == Guid.Empty)
            {
                return null;
            }
            
            return await __Context.Tag.FindAsync(uid);
        }

    }
}