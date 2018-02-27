using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Map.Interfaces
{
    public interface IMapping<T> where T : class
    {
        void MapEntity(EntityTypeBuilder<T> builder);
    }
}
