using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public bool ChangeStart;
    public string ToSceneName;//宛先のシーン名

    // Start is called before the first frame update
    void Start()
    {
        ChangeStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeStart == true)
        {
            SceneManager.LoadScene(ToSceneName);
        }
    }
}
//シーンを変えたいときこれを書く
//GameObject.Find("SceneChange").GetComponent<SceneChange>().ChangeStart = true;