using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RMDSCM
{
    class BMBGImage : Image
    {
        public UInt16 nothing1;
        public UInt32 nothing2;

        public byte[] puzzle;

        public BMBGImage()
        {
        }

        ~BMBGImage()
        {
        }
    }
}
