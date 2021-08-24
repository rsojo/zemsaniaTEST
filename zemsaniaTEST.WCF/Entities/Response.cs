using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zemsaniaTEST.WCF.Entities
{
    public class Response<T>
    {
        public string Msg { get; set; }
        public bool Error { get; set; }
        public T UnitResp { get; set; }
        List<T> _lst;
        public List<T> Lst
        {
            get { return _lst == null ? new List<T>() : _lst; }
            set { _lst = value; }
        }
    }
}