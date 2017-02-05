using System.Collections.Generic;
using WinEv3.Core.Block;
using WinEv3.Core.Types;

namespace WinEv3.Core.Events
{
    public sealed class StateChangedEventArgs : Ev3EventArgs
    {
        public IDictionary<InputPortTypes, Port> PortState { get; set; }
        
        public ButtonState ButtonState { get; set; }
    }
}