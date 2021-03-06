﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Relational.Query.Pipeline.SqlExpressions;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     Represents a relational database function in an <see cref="IMutableModel" /> in
    ///     the a form that can be mutated while the model is being built.
    /// </summary>
    public interface IMutableDbFunction : IDbFunction
    {
        /// <summary>
        ///     The name of the function in the database.
        /// </summary>
        new string FunctionName { get; [param: NotNull] set; }

        /// <summary>
        ///     The schema of the function in the database.
        /// </summary>
        new string Schema { get; [param: CanBeNull] set; }

        /// <summary>
        ///     The <see cref="IMutableModel" /> in which this function is defined.
        /// </summary>
        new IMutableModel Model { get; }

        /// <summary>
        ///     A translation callback for performing custom translation of the method call into a SQL expression fragment.
        /// </summary>
        new Func<IReadOnlyCollection<SqlExpression>, SqlExpression> Translation { get; [param: CanBeNull] set; }
    }
}
