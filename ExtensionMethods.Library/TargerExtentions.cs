using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Library
{
    public static class TargerExtentions
    {
        //internal static void ExtendInternal(this InternalTarget target)
        //{

        //}

        public static string GetStandardizedId(this Target target)
        {
            return target.getId().ToUpper();
        }
    }
}
