using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Practice_Event
    {
        public string text;
        public event EventHandler Click;

        public void MouseButtonDown()
        {
            if(this.Click != null)
            {
                Click(this, EventArgs.Empty);
            }
        }

    }
}
