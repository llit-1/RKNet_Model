using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RKNet_Model.MSSQL
{
    public class SkuStopState
    {
        public int TTId;
        public int? TTCode;
        public string TTName;
        public int cashId;
        public string CashName;

        public bool blocked;

        public string error;
    }
}
