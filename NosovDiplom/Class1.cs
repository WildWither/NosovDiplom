using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace NosovDiplom
{
    internal static class BuhMathf
    {

        public static float GetGrowth(float Before, float After)
        {
           if (After > Before)
            {
                return (After - Before)/Before * 100;
            }
           else
            {
                return 0;
            }
        }

    }
}
