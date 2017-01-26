using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Scenes
{
    public class MainMenuScene : AbstractBaseScene, IScene<GameContextController>
    {
        public string name
        {
            get
            {
                return "Main Menu";
            }
        }

        public GameContextController controller { get; set; }

        private readonly string canvasPath = "Main Menu";
        private readonly string startButtonPath = string.Join("/", new string[] { "Main Menu", "Main Panel", "Start Button" });
        private readonly string quitButtonPath = string.Join("/", new string[] { "Main Menu", "Main Panel", "Quit Button" });

        public GameObject canvas { get; set; }
        public Button startButton { get; set; }
        public Button quitButton { get; set; }

        public MainMenuScene(GameContextController controller) : base(controller)
        {

        }

        public void receiveInput()
        {
            throw new NotImplementedException();
        }

        public void SetScene()
        {
            canvas = GameObject.Find(canvasPath);
            startButton = GameObject.Find(startButtonPath).GetComponent<Button>();
            quitButton = GameObject.Find(quitButtonPath).GetComponent<Button>();

            startButton.onClick.AddListener(() => 
                GameContextController.Instance.LoadScene(GameContextController.Instance.mainScene));

            quitButton.onClick.AddListener(() => Application.Quit());
        }
    }
}
