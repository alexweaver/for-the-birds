
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class AbstractBaseView : MonoBehaviour
    {
        public IController controller;
        public new GameObject gameObject { get; set; }

        public AbstractBaseView()
        {
            gameObject = GetEmptyGameObject();
        }

        public AbstractBaseView(IController controller)
        {
            this.controller = controller;
            gameObject = GetEmptyGameObject();
        }

        public AbstractBaseView(GameObject gameObject)
        {
            gameObject = gameObject != null ? gameObject : GetEmptyGameObject();
        }

        public AbstractBaseView(IController controller, GameObject gameObject)
        {
            this.controller = controller;
            gameObject = gameObject != null ? gameObject : GetEmptyGameObject();
        }

        private GameObject GetEmptyGameObject()
        {
            return new GameObject(GetType().Name);
        }
    }
}
