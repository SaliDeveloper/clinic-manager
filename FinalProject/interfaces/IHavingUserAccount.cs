namespace FinalProject.Interfaces
{
    public interface IHavingUserAccount
    {
        UserAccount UserAccount { get; }
    }

    public class UserAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}