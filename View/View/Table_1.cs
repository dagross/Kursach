using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class Table_1
    {
        public int id { get; set; }
        public string Adress { get; set; }
        public string CountNum { get; set; }
        public Table_1(int id,string adress,string CountName)
        {
            this.Adress = adress;
            this.CountNum = CountName;
            this.id = id;
        }

    }
}
