using System;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts.Scenes
{
    public class MainScene : AbstractBaseScene, IScene<GameContextController>
    {
        public string name
        {
            get
            {
                return "Main";
            }
        }

        public GameContextController controller { get; set; }

        private readonly string inGameMenuCanvasPath = "In-Game Menu";
        private readonly string shopButtonPath = string.Join("/", new string[] { "In-Game Menu", "Shop Button" });

        private readonly string shopMenuCanvasPath = "Shop Menu";

        public GameObject canvas { get; set; }
        public Canvas shopMenuCanvas { get; set; }

        public Button shopButton { get; set; } 

        public MainScene(GameContextController controller) : base(controller)
        {

        }

        public void receiveInput()
        {

        }

        public void SetScene()
        {
            canvas = GameObject.Find(inGameMenuCanvasPath);

            shopMenuCanvas = GameObject.Find(shopMenuCanvasPath).GetComponent<Canvas>();
            shopMenuCanvas.enabled = false;

            shopButton = GameObject.Find(shopButtonPath).GetComponent<Button>();
            shopButton.onClick.AddListener(() =>
                ToggleShop());
        }

        public void ToggleShop()
        {
            if (shopMenuCanvas != null)
            {
                shopMenuCanvas.enabled = !shopMenuCanvas.enabled;
            }
        }
    }
}