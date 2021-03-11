using harmonicus.Model;

namespace harmonicus.Repository
{
    public interface IPsychologistRepository : IRepository<Psychologist>
    {
        Psychologist Disable(long id);
    }
}
