﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Dock.Avalonia.Editor.Controls
{
    public class DockWindowPropertiesControl : UserControl
    {
        public DockWindowPropertiesControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
