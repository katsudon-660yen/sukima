using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUI_Count : MonoBehaviour
{
    //カウントする時間
    [SerializeField]
    private float countTime = 60.0f;
    
    //Timeから最初に貰うtime
    private float starttime = 0;

    //計算用カウントの最大値
    private float maxcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
        maxcount = countTime;
    }

    // Update is called once per frame
    void Update()
    {
        //時間の更新
        {
            float freamtime = (Time.time - starttime);
            countTime = maxcount - freamtime;

            //countTimeが0未満にならないように
            if (countTime <= 0)
            {
                countTime = 0;
            }
        }
    }

    //時間を渡す
    public float GetTime()
    {
        return countTime;
    }

    //カウンターを再設定
    public void ResetTime(int settime)
    {
        starttime = Time.time;
        maxcount = settime;
    }
}
