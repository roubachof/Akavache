﻿// Copyright (c) 2021 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.IO;
using Akavache.Sqlite3;

namespace Akavache.Tests.Performance
{
    /// <summary>
    /// Read tests for the <see cref="SqlRawPersistentBlobCache"/> class.
    /// </summary>
    public abstract class Sqlite3ReadTests : ReadTests
    {
        /// <inheritdoc/>
        protected override IBlobCache CreateBlobCache(string path)
        {
            return new SqlRawPersistentBlobCache(Path.Combine(path, "blob.db"));
        }
    }
}
