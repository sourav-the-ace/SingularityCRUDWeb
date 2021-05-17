using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryAPI.Models
{
    public class LoginInfo
    {
        public string Timestamp { get; set; }
        public long Status { get; set; }
        public string Message { get; set; }
        public List<Datum> Data { get; set; }
    }

    public  class Datum
    {
        public long Id { get; set; }
        public string UseRId { get; set; }
        public string fulL_NAME { get; set; }
        public string useR_EMAIL { get; set; }
        public string useR_LOGIN_NAME { get; set; }
        public long useR_LOGIN_PASS { get; set; }
        public string useR_TYPE { get; set; }
    }
}
