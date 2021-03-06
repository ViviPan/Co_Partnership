﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Co_Partnership.Models.Database;


namespace Co_Partnership.Services
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transactions { get; }

        void UpdateTransaction(Transaction transaction);

        Transaction SaveTransaction(Transaction transaction);

        Transaction DeleteTransaction(int transactionId);

        IEnumerable<Object> ListTransactions(int type);

        IEnumerable<Object> ListItems(int orderId);

        double? CountItems(int type);

        int NewTransactionCount(int type);

        Transaction GetIncompleteTransaction(int userId);

        IEnumerable<Object> GetPurchaseHistory(int userId);


        IEnumerable<Object> getSummaries(int id,DateTime start,DateTime end);


        Object SummarizeNewTransactions(int type);
    }
}
