using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IView
    {
        GameObject gameObject { get; set; }
    }
    public interface IView<C> : IView where C : IController { }
}
