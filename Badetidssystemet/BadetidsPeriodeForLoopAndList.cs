using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriodeForLoopAndList : BadetidsPeriode
    {
        List<Kreds> _kredseList;

        public BadetidsPeriodeForLoopAndList(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
            : base (type, ugeDag,  startTidspunkt, slutTidspunkt)
        {
            _kredseList = new List<Kreds>();
        }

        public override void AdderKreds(Kreds kreds)
        {
            _kredseList.Add(kreds);
        }
      
        public override void SletKreds(string id)
        {
            int idxFound = (-1);

            for (int idx = 0; idx < _kredseList.Count; idx++)
            {
                if (_kredseList[idx].ID == id)
                {
                    idxFound = idx;
                    break;
                }
            }

            if (idxFound > (-1))
            {
                _kredseList.RemoveAt(idxFound);
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            for (int idx = 0; idx < _kredseList.Count; idx++)
            {
                result += _kredseList[idx];
                result += "\r\n";
            }
            return result;
        }
    }
}
