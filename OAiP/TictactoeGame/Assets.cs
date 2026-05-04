using System;
using System.Collections.Generic;
using System.Text;

namespace Tictactoe
{
    public class Assets
    {
        public static Image Cross, Zero;

        public static void Load()
        {
            String crossPath = Path.Combine(Application.StartupPath, "cross.png");
            String zeroPath = Path.Combine(Application.StartupPath, "zero.png");
            if (File.Exists(crossPath) && File.Exists(zeroPath))
            {
                Cross = Image.FromFile(crossPath);
                Zero = Image.FromFile(zeroPath);
            }
            else
            {
                throw new FileNotFoundException("Error loading images");
            }
        }
    }
}
