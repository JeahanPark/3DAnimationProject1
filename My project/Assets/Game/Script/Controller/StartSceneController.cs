using System;
using UnityEngine;

public class StartSceneController : MonoBehaviour
{
    private void Start()
    {
        Managers.Scene.SceneChange(SceneType.LobbyScene);
    }
}
