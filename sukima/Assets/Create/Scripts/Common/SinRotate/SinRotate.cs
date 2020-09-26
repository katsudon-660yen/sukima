using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinRotate : MonoBehaviour
{
    [SerializeField]
    Vector3 _rotateSpeed;

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
        _targetTrans.Rotate(_rotateSpeed * Time.deltaTime * Mathf.Sin(_counter));
        // カウントアップ
        _counter += Time.deltaTime;
    }
}
