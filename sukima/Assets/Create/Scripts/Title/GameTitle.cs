using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTitle : MonoBehaviour
{
    public void OnClickStartButton()
    {
        //ここに遷移させるシーン名
        SceneManager.LoadScene("Title_Scene");
    }
}