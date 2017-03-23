using OrientDB.Net.Core.Models;
using System.Collections.Generic;

namespace OrientDB.Net.Core.Abstractions
{
    public interface IOrientConnection
    {
        IEnumerable<TResultType> ExecuteQuery<TResultType>(string sql) where TResultType : OrientDBEntity;
        IOrientDBCommandResult ExecuteCommand(string sql);
        IOrientDBTransaction CreateTransaction();
        IOrientDBDatabaseHandle CreateDatabase(string name, StorageType storage);
        void DeleteDatabase(IOrientDBDatabaseHandle handle);
    }
}
