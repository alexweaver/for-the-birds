using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class BirdModel
    {
        public static readonly List<BirdModel> Birds = new List<BirdModel>()
        {
            new BirdModel("Pidgeon", 25, "birds1-02", "Prefabs/Pidgeon")
            , new BirdModel("Canary", 10, "birds1-03", "Prefabs/Canary")
            , new BirdModel("Swan", 100, "birds1-04", "Prefabs/Swan")
        };

        public string Name { get; set; }
        public Sprite BirdSprite { get; set; }
        public int Cost { get; set; }
        public GameObject Prefab { get; set; }

        public BirdModel(string name, int cost, string spritePath, string prefabPath)
        {
            Name = name;
            Cost = cost;

            BirdSprite = Resources.Load<Sprite>(spritePath);
            Prefab = Resources.Load<GameObject>(prefabPath);
        }
    }
}
