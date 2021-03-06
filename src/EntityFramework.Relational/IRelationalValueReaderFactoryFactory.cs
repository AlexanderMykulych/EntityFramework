// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Relational
{
    public interface IRelationalValueReaderFactoryFactory
    {
        IRelationalValueReaderFactory CreateValueReaderFactory([NotNull] IEnumerable<Type> valueTypes, int offset);
    }
}
