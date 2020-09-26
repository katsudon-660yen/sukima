using UnityEngine;
using UnityEngine.SceneManagement;


public class GameEnd : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }
    public void OnClickStartButton()
    {
        audioSource.PlayOneShot(sound1);
        //ここに遷移させるシーン名
        Invoke("Quit", 0.8f);
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
