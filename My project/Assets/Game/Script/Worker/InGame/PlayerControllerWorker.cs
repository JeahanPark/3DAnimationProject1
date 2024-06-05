using System;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerWorker : MonoBehaviour
{
    private CinemachineCamera _camera;

    private CinemachineCamera SetCamera
    {
        set
        {
            _camera = value;
            SettingCamera();
        }
    }
    
    private Unit _player;

    public Unit SetPlayer
    {
        set
        {
            _player = value;
            SettingCamera();
        }
    }

    private void OnMove(InputValue inputSystem)
    {
        var dir = inputSystem.Get<Vector2>();
        _player.Move(dir);
    }

    public void Init(CinemachineCamera playerCamera, Unit player)
    {
        _camera = playerCamera;
        _player = player;
        
        SettingCamera();
    }

    private void SettingCamera()
    {
        if (_camera == null || _player == null)
            return;
        
        _camera.Follow = _player.transform;
    }

}
