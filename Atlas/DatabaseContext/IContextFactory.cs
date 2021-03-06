﻿// // -----------------------------------------------------------------------
// // <copyright file="IContextFactory.cs">
// //     Copyright 2020 Clint Irving
// //     All rights reserved.
// // </copyright>
// // <author>Clint Irving</author>
// // -----------------------------------------------------------------------

namespace Atlas.DatabaseContext
{
    public interface IContextFactory
    {
        IContext Create();
    }
}