﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Xunit;

namespace Dock.Model.UnitTests
{
    public class ListContractResolverTests
    {
        [Fact]
        public void DockManager_Ctor()
        {
            var actual = new DockManager();
            Assert.NotNull(actual);
        }
    }
}
