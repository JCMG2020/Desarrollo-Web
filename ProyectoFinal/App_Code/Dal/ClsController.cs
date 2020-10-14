using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ProyectoFinal.App_Code.Dal
{
    public class ClsController
    {
        DataSet dsReturn;
        public DataSet DsReturn
        {
            get
            {
                return dsReturn;
            }
            set
            {
                dsReturn = value;
            }
        }
    }
}