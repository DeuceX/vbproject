namespace DAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {

        ICardRepository CardRepository { get; set; }
        ICardSetRepository CardSetRepository { get; set; }
        IUserRepository UserRepository { get; set; }

        void Commit();
    }
}
