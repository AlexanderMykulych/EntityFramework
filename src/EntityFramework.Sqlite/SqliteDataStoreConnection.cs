﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Data.Common;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Relational;
using Microsoft.Data.Sqlite;
using Microsoft.Framework.Logging;

namespace Microsoft.Data.Entity.Sqlite
{
    public class SqliteDataStoreConnection : RelationalConnection, ISqliteConnection
    {
        public SqliteDataStoreConnection([NotNull] IDbContextOptions options, [NotNull] ILoggerFactory loggerFactory)
            : base(options, loggerFactory)
        {
        }

        protected override DbConnection CreateDbConnection() => new SqliteConnection(ConnectionString);
    }
}
