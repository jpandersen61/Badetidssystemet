﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        string _type;
        DayOfWeek _ugeDag;
        DateTime _startTidspunkt;
        DateTime _slutTidspunkt;

        public string Type { get { return _type;} private set { _type = value; } }
        public DayOfWeek UgeDag { get { return _ugeDag; } private set { _ugeDag = value; } }
        public DateTime StartTidspunkt { get { return _startTidspunkt; } private set { _startTidspunkt = value; } }
        public DateTime SlutTidspunkt { get { return _slutTidspunkt; } private set { _slutTidspunkt = value; } }

        Dictionary<string, Kreds> _kredse;

        public BadetidsPeriode()
        {
            Type = "Badning";
            UgeDag = DayOfWeek.Sunday;
            StartTidspunkt = new DateTime();
            SlutTidspunkt = new DateTime();
            _kredse = new Dictionary<string, Kreds>();
        }

        public BadetidsPeriode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            Type = type;
            UgeDag = DayOfWeek.Sunday;
            StartTidspunkt = startTidspunkt;
            SlutTidspunkt = slutTidspunkt;
            _kredse = new Dictionary<string, Kreds>();
        }

        public override string ToString()
        {
            string result = $"Type:{Type}, Ugedag:{UgeDag}, Start:{StartTidspunkt.TimeOfDay}, Slut: {SlutTidspunkt.TimeOfDay}";
            result +="\r\n";
            result += "Kredse:";
            result += "\r\n";
            foreach (Kreds k in _kredse.Values)
            {
                result += k;
                result += "\r\n";
            }

            return result;
        }
    }
}