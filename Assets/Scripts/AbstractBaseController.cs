using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public abstract class AbstractBaseController
    {
        string name {get; set;}
        public  IModel model;
        public IView view;
    }
}
