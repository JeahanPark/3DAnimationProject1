using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

public class LoadingSceneController : MonoBehaviour
{
    private string _sceneName;
    private void Start()
    {
        _sceneName = Managers.Scene.GetCurentScene().ToString();
         Func<UniTask> asyncLambda = async () =>
         {
             await Loading();
         };
        
        asyncLambda();
    }
    
    private async UniTask Loading()
    {
        await UniTask.Delay(1);
        Debug.Log(_sceneName.ToString());
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName);
    }
}
