﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Azure.WebJobs.Host.Converters
{
    internal static class TToStringConverterFactory
    {
        public static IConverter<TInput, string> TryCreate<TInput>()
        {
            if (typeof(TInput) == typeof(string))
            {
                return (IConverter<TInput, string>)new IdentityConverter<string>();
            }
            else if (typeof(TInput) == typeof(char))
            {
                return (IConverter<TInput, string>)new CharToStringConverter();
            }
            else if (typeof(TInput) == typeof(byte))
            {
                return (IConverter<TInput, string>)new ByteToStringConverter();
            }
            else if (typeof(TInput) == typeof(sbyte))
            {
                return (IConverter<TInput, string>)new SByteToStringConverter();
            }
            else if (typeof(TInput) == typeof(short))
            {
                return (IConverter<TInput, string>)new Int16ToStringConverter();
            }
            else if (typeof(TInput) == typeof(ushort))
            {
                return (IConverter<TInput, string>)new UInt16ToStringConverter();
            }
            else if (typeof(TInput) == typeof(int))
            {
                return (IConverter<TInput, string>)new Int32ToStringConverter();
            }
            else if (typeof(TInput) == typeof(uint))
            {
                return (IConverter<TInput, string>)new UInt32ToStringConverter();
            }
            else if (typeof(TInput) == typeof(long))
            {
                return (IConverter<TInput, string>)new Int64ToStringConverter();
            }
            else if (typeof(TInput) == typeof(ulong))
            {
                return (IConverter<TInput, string>)new UInt64ToStringConverter();
            }
            else if (typeof(TInput) == typeof(Guid))
            {
                return (IConverter<TInput, string>)new GuidToStringConverter();
            }
            else
            {
                return null;
            }
        }
    }
}