using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class Startup: MonoBehaviour
    {
        void Awake()
        {
            StartGame();
        }

        void StartGame()
        {
            GameContextController.Instance.LoadScene(GameContextController.Instance.mainMenuScene);
        }
    }
}
