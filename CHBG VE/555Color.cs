using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace RMDSCM
{
    class _555Color
    {
        public Color Color;
        public UInt16 Int16;

        public _555Color(UInt16 palette_color)
        {
            Int16 = palette_color;
            // Formato BGR
            // 5 primeros bits  0x7C00
            // 6 medios         0x03E0
            // 5 ultimos        0x001F
            int blue  = (palette_color & 0x7C00) >> 7;
            int green = (palette_color & 0x03E0) >> 2;
            int red   = (palette_color & 0x001F) << 3;
            Color = Color.FromArgb(red, green, blue);
        }

        public _555Color(Color palette_color)
        {
            Color = palette_color;
            int blue  = (palette_color.B << 7) & 0x7C00;
            int green = (palette_color.G << 2) & 0x03E0;
            int red   = (palette_color.R >> 3) & 0x001F;

            Int16 = (UInt16)(blue | green | red);
        }
    }
}
