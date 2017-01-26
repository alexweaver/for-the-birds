using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IController {}
    public interface IController<M, V> : IController where M : IModel where V : IView { }
}