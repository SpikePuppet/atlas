﻿// // -----------------------------------------------------------------------
// // <copyright file="AuditMeAttribute.cs">
// //     Copyright 2020 Clint Irving
// //     All rights reserved.
// // </copyright>
// // <author>Clint Irving</author>
// // -----------------------------------------------------------------------

using System;

namespace Atlas.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuditMeAttribute : Attribute
    {
    }
}