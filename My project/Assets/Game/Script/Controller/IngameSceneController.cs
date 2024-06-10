using System;
using Cysharp.Threading.Tasks;
using Unity.Cinemachine;
using UnityEngine;

public class IngameSceneController : BaseController
{
    [SerializeField] private CinemachineCamera playerCamera;
    
    [SerializeField] private PlayerControllerWorker playerControllerWorker;
    public PlayerControllerWorker PlayerControllerWorker => playerControllerWorker;

    [SerializeField] private Unit player;

    private void Start()
    {
        Loading();
    }

    private async UniTask Loading()
    {
        // 플레이어 컨트롤러 세팅
        playerControllerWorker.Init(playerCamera, player);
    }
}
