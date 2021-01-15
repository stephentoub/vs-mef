// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.Composition
{
    using System;

    public class PartDiscoveryException : Exception
    {
        public PartDiscoveryException()
        {
        }

        public PartDiscoveryException(string message)
            : base(message)
        {
        }

        public PartDiscoveryException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public string? AssemblyPath { get; set; }

        public Type? ScannedType { get; set; }
    }
}
