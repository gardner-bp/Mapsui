﻿using Mapsui.Styles;

namespace Mapsui.Widgets
{
    public abstract class TextBox : Widget // abstract for now, since there is no renderer.
    {
        public int PaddingX { get; set; }
        public int PaddingY { get; set; }
        public int CornerRadius { get; set; } = 3;
        public string Text { get; set; }
        public Color BackColor { get; set; } = new Color(255, 255, 255, 128);
        public Color TextColor { get; set; } = new Color(0, 0, 0);
    }
}