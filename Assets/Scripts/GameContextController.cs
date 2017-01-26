using Assets.Scripts;
using Assets.Scripts.Scenes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class GameContextController: AbstractBaseController, IController<GameContextModel, GameContextView>
{
    IScene<GameContextController> currentScene { get; set; }

    public MainMenuScene mainMenuScene;
    public MainScene mainScene;

    public Dictionary<string, IScene<GameContextController>> sceneDictionary;

    private static readonly string tag = "GameContextController";
    private static void log(string message)
    {
        Debug.Log(tag + ": " + message);
    }

    private static GameContextController instance;
    public static GameContextController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameContextController();
            }
            return instance;
        }
    }

    private GameContextController()
    {
        if (instance != null & instance != this)
        {
            instance = this;
        }

        mainMenuScene = new MainMenuScene(this);
        mainScene = new MainScene(this);

        sceneDictionary = new Dictionary<string, IScene<GameContextController>>();
        sceneDictionary.Add(mainMenuScene.name, mainMenuScene);
        sceneDictionary.Add(mainScene.name, mainScene);
        sceneDictionary.Add("Start", null);

        log("Create GameContextController");

        model = new GameContextModel();
        view = new GameContextView(this);


        log("Successfully Created GameContextController");

        log("Loading Main Menu");


        log("Main Menu Loaded");

        SceneManager.sceneLoaded += ((Scene scene, LoadSceneMode mode) =>
        {
            if (scene.name != "Start")
            {
                SetScene(sceneDictionary[scene.name]);
            }
        });
    }

    public void LoadScene(IScene<GameContextController> scene)
    {
        log(scene.name);
        SceneManager.LoadScene(scene.name);
    }

    public void SetScene(IScene<GameContextController> scene)
    {
        currentScene = scene;
        currentScene.SetScene();
    }
}