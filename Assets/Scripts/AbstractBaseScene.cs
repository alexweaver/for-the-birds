using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public abstract class AbstractBaseScene
    {

        string name { get; set; }
        IController controller;

        public AbstractBaseScene(IController controller)
        {
            this.controller = controller;
        }
    }
}
