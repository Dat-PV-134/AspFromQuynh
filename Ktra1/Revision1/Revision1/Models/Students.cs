using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Linq;
using System.Web;

namespace Revision1.Models
{
    public class Students
    {
        [DisplayName("Nhập mã sv: ")]
        public string sId { get; set; }

        [DisplayName("Nhập tên: ")]
        public string sName { get; set; }

        [DisplayName("Nhập tuổi: ")]
        public int Age { get; set; }

        [DisplayName("Nhập địa chỉ: ")]
        public string Addr { get; set; }

        public Students()
        {
            
        }

        public Students(string id, string name, int age, string addr)
        {
            this.sId = id;
            this.sName = name;
            this.Age = age;
            this.Addr = addr;
        }
    }
}