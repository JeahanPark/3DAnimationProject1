using System;
using Unity.Cinemachine;
using UnityEngine;

public class IngameSceneController : MonoBehaviour
{
    [SerializeField] private CinemachineCamera playerCamera;
    
    [SerializeField] private PlayerControllerWorker playerControllerWorker;

    [SerializeField] private Unit player;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        // 플레이어 컨트롤러 세팅
        playerControllerWorker.Init(playerCamera, player);
    }
}
