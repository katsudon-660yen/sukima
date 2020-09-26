using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRotate : MonoBehaviour
{
    [SerializeField]
    Vector3 _rotateSpeed;

    [SerializeField]
    float _switchTime;

    float _counter;
    private Transform _targetTrans;
    // Start is called before the first frame update
    void Start()
    {
        _targetTrans = this.gameObject.transform;
        _counter = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // 回転
        _targetTrans.Rotate(_rotateSpeed * Time.deltaTime);
        // カウントアップ
        _counter += Time.deltaTime;
        // 指定時間超えたら
        if(_counter > _switchTime)
        {
            // 回転方向の反転
            _rotateSpeed *= -1;
            // カウントリセット
            _counter = 0.0f;
        }
    }
}
