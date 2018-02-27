﻿namespace DAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {

        ICardRepository CardRepository { get; set; }
        ICardSetRepository CardSetRepository { get; set; }
        ICustomerRepository CustomerRepository { get; set; }

        void Commit();
    }
}
