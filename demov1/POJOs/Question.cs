using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demov1.POJOs
{
    class Question
    {
        public int id { get; set; }
        public string q { get; set; }

        public string op1 { get; set; }
        public string op2 { get; set; }
        public string op3 { get; set; }
        public string op4 { get; set; }
        public string opCorrect { get; set; }

        public int eid { get; set; }

        Question(string q,string op1, string op2, string op3, string op4, string opCorrect,int eid)
        {
            this.q = q;
            this.op1 = op1;
            this.op2 = op2;
            this.op3 = op3;
            this.op4 = op4;
            this.opCorrect = opCorrect;
            this.eid = eid;
        }
        
        Question()
        {

        }


    }
}
