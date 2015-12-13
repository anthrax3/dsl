//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Akka;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Demo.Indexing.Account.Messages
{
    using Demo.Indexing.Account.Entities;
    
    public class StoreAccount
    {
        public AccountIndexEntry Entry { get; private set; }//;
        public StoreAccount(AccountIndexEntry entry)
        {
            this.Entry = entry;
        }
        public virtual StoreAccount SetProperties(AccountIndexEntry entry = default(AccountIndexEntry))
        {
            AccountIndexEntry localEntry = entry;
            if ((entry == default(AccountIndexEntry)))
            {
                localEntry = this.Entry;
            }
            return new StoreAccount(localEntry);
        }
    }
    public class AccountStored
    {
        public AccountIndexEntry Entry { get; private set; }//;
        public AccountStored(AccountIndexEntry entry)
        {
            this.Entry = entry;
        }
        public virtual AccountStored SetProperties(AccountIndexEntry entry = default(AccountIndexEntry))
        {
            AccountIndexEntry localEntry = entry;
            if ((entry == default(AccountIndexEntry)))
            {
                localEntry = this.Entry;
            }
            return new AccountStored(localEntry);
        }
    }
    public class AccountStorageFailed
    {
        public AccountIndexEntry Entry { get; private set; }//;
        public Exception Reason { get; private set; }//;
        public AccountStorageFailed(AccountIndexEntry entry, Exception reason = default(Exception))
        {
            this.Entry = entry;
            this.Reason = reason;
        }
        public virtual AccountStorageFailed SetProperties(AccountIndexEntry entry = default(AccountIndexEntry), Exception reason = default(Exception))
        {
            AccountIndexEntry localEntry = entry;
            if ((entry == default(AccountIndexEntry)))
            {
                localEntry = this.Entry;
            }
            Exception localReason = reason;
            if ((reason == default(Exception)))
            {
                localReason = this.Reason;
            }
            return new AccountStorageFailed(localEntry, localReason);
        }
    }
    public class DeleteAccount
    {
        public Guid UserId { get; private set; }//;
        public DeleteAccount(Guid userId)
        {
            this.UserId = userId;
        }
        public virtual DeleteAccount SetProperties(Guid userId = default(Guid))
        {
            Guid localUserId = userId;
            if ((userId == default(Guid)))
            {
                localUserId = this.UserId;
            }
            return new DeleteAccount(localUserId);
        }
    }
    public class AccountDeleted
    {
        public AccountIndexEntry Entry { get; private set; }//;
        public AccountDeleted(AccountIndexEntry entry)
        {
            this.Entry = entry;
        }
        public virtual AccountDeleted SetProperties(AccountIndexEntry entry = default(AccountIndexEntry))
        {
            AccountIndexEntry localEntry = entry;
            if ((entry == default(AccountIndexEntry)))
            {
                localEntry = this.Entry;
            }
            return new AccountDeleted(localEntry);
        }
    }
    public class AccountDeletionFailed
    {
        public Guid UserId { get; private set; }//;
        public Exception Reason { get; private set; }//;
        public AccountDeletionFailed(Guid userId, Exception reason = default(Exception))
        {
            this.UserId = userId;
            this.Reason = reason;
        }
        public virtual AccountDeletionFailed SetProperties(Guid userId = default(Guid), Exception reason = default(Exception))
        {
            Guid localUserId = userId;
            if ((userId == default(Guid)))
            {
                localUserId = this.UserId;
            }
            Exception localReason = reason;
            if ((reason == default(Exception)))
            {
                localReason = this.Reason;
            }
            return new AccountDeletionFailed(localUserId, localReason);
        }
    }
}