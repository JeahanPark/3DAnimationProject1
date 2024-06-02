using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class LobbyUIWorker : MonoBehaviour
{
    [SerializeField] private Button ingameEnterBtn;

    private void Awake()
    {
        ingameEnterBtn.OnClickAsObservable().Subscribe(_ =>
        {
            Managers.Scene.SceneChange(SceneType.InGameScene);
        });
    }
}
