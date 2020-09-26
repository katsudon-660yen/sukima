using UnityEngine;
using UnityEngine.SceneManagement;


public class GameEnd : MonoBehaviour
{
    public void OnClickStartButton()
    {
        //ここに遷移させるシーン名
        Quit();
    }
    void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
    #endif
    }
}
