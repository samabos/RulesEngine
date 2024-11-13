﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;

namespace RulesEngine.Models
{
    [ExcludeFromCodeCoverage]
    public class ImplicitObject
    {

        #region Implicit Operators

        public static implicit operator ImplicitObject(bool value) => default;

        public static implicit operator ImplicitObject(bool? value) => default;

        public static implicit operator ImplicitObject(char value) => default;

        public static implicit operator ImplicitObject(char? value) => default;

        public static implicit operator ImplicitObject(string value) => default;

        public static implicit operator ImplicitObject(int value) => default;

        public static implicit operator ImplicitObject(int? value) => default;

        public static implicit operator ImplicitObject(decimal value) => default;

        public static implicit operator ImplicitObject(decimal? value) => default;

        #endregion

    }
}
