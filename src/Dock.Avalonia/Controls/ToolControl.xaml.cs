﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Dock.Avalonia.Controls
{
    /// <summary>
    /// Interaction logic for <see cref="ToolControl"/> xaml.
    /// </summary>
    public class ToolControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolControl"/> class.
        /// </summary>
        public ToolControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initialize the Xaml components.
        /// </summary>
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
