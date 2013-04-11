﻿using System;

namespace WindowsAzure.Table.Attributes
{
    /// <summary>
    ///     Defines whether property keep timestamp value.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class TimestampAttribute : Attribute
    {
    }
}