using System;
using System.Collections.Generic;
using System.Text;

namespace Payee
{
    class Payee :PayeeMgr
    {
        private int payeeId;
        private int accNo;
        private String accName;
        private String bank;

        public int PayeeId { get => payeeId; set => payeeId = value; }
        public string AccName { get => accName; set => accName = value; }
        public string Bank { get => bank; set => bank = value; }
        public int AccNo { get => accNo; set => accNo = value; }
    }
}
