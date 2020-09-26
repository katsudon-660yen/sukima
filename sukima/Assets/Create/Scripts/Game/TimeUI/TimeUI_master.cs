using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUI_master : MonoBehaviour
{
    [SerializeField]
    private TimeUI_Number[] TimeNumber = { };

    [SerializeField]
    private TimeUI_Count TimeCount = null;

    // Update is called once per frame
    void Update()
    {
        float gettime = TimeCount.GetTime();
        int i_time = (int)(gettime * 100);

        for(int i = TimeNumber.Length - 1;i>=0;i--)
        {
            int num = 0;
            if (i_time > 0)
            {
                num = i_time % 10;
            }
            TimeNumber[i].SetNumber(num);
            i_time /= 10;
        }
    }
}
