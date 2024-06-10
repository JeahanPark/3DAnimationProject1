using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers _instance; // 유일성이 보장된다

    public static Managers Instance
    {
        get
        {
            InitInstance();
            return _instance;
        }
    }

    private SceneManager _sceneManager = new SceneManager();
    public static SceneManager Scene => Instance._sceneManager;
    
    private static void InitInstance()
    {
        if (_instance == null)
        {
            GameObject go = GameObject.Find("Managers");
            if (go == null)
            {
                go = new GameObject {name = "Managers"};
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            _instance = go.GetComponent<Managers>();
        }
    }
}
