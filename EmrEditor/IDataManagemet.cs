using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmrEditor
{
    interface IDataManagemet
    {
        void ExportHtml();
        string ExportToString();
    }
}
