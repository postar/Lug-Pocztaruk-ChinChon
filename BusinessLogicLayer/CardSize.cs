using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public static class CardSize
    {
		private static readonly int width = 73;

		public static int Width
		{
			get { return width; }
		}

        private static readonly int height = 95;

        public static int Height
        {
            get { return height; }
        }

    }
}