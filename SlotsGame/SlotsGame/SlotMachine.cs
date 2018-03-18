﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotsGame
{
    public static class SlotMachine
    {
        public static Image[] pics =
        {
            Image.FromFile(@"..\..\banana.png"),
            Image.FromFile(@"..\..\bar.png"),
            Image.FromFile(@"..\..\cherry.png"),
            Image.FromFile(@"..\..\lemon.png"),
            Image.FromFile(@"..\..\lucky7.png"),
            Image.FromFile(@"..\..\melon.png"),
            Image.FromFile(@"..\..\orange.png"),
            Image.FromFile(@"..\..\plum.png")
        };

        public static void Roll(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();

            pb1.Image = new Bitmap(pics[r1.Next(8)],pb1.Size);
            pb2.Image = new Bitmap(pics[r2.Next(8)],pb2.Size);
            pb3.Image = new Bitmap(pics[r3.Next(8)],pb3.Size);

        } 
    }
}