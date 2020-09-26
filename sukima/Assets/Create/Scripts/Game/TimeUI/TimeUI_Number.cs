using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI_Number : MonoBehaviour
{
    //数字の画像 0～9
    [SerializeField]
    private Sprite[] numbersprite = { };

    //表示する数字
    [SerializeField]
    private int number = 0;

    // 表示する数字を入力し切り替える
    public void SetNumber(int setnumber)
    {
        number = setnumber%10;
        GetComponent<Image>().sprite = numbersprite[number];
    }
}
