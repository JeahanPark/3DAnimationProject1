

public enum SceneType
{
    None,
    LoadingScene,
    StartScene,
    LobbyScene,
    InGameScene,
}
public class SceneManager
{
    private SceneType _eCurrentScene = SceneType.None;

    private readonly string _strLoadingScene = SceneType.LoadingScene.ToString();
    
    public void SceneChange(SceneType eSceneType)
    {
        _eCurrentScene = eSceneType;
        UnityEngine.SceneManagement.SceneManager.LoadScene(_strLoadingScene);
    }

    public SceneType GetCurentScene()
    {
        return _eCurrentScene;
    }
}
