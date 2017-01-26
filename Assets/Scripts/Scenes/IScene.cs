using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IScene<C> where C: IController
    {
        string name { get; }
        C controller { get; set; }
        void receiveInput();
        void SetScene();

        GameObject canvas { get; set; }
    }
}
