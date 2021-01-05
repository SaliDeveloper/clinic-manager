using FinalProject.Main_Classes;

namespace FinalProject.Interfaces
{
    public interface IPerson
    {
        long Id { get; }
        IProfile Profile { get; set; }
    }
}
