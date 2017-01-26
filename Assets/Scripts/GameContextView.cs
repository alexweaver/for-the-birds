using Assets.Scripts;
using UnityEngine;

public class GameContextView : AbstractBaseView, IView
{
    public GameContextView(GameContextController controller) : base(controller)
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log(controller);
    }

    
}