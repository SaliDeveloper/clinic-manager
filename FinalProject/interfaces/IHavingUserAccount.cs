namespace FinalProject.Interfaces
{
    public interface IHavingUserAccount
    {
        UserAccount Account { get; }
    }

    public class UserAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}