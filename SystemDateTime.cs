using ControllerDI.Interfaces;
using System;

namespace ControllerDI.Services

{
    public class SystemDateTime : IDateTime 
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}
