using BrightIdeasSoftware;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class AlphabeticalComparer : IComparer<OLVListItem>
    {

        public int Compare(OLVListItem x, OLVListItem y)
        {
            return String.Compare(((dynamic)x.RowObject).name , ((dynamic)y.RowObject).name);
        }
    }
}
