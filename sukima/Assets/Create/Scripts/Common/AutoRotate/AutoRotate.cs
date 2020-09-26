using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField]
    Vector3 _rotateSpeed;

    private Transform _targetTrans;
    // Start is called before the first frame update
    void Start()
    {
        _targetTrans = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        _targetTrans.Rotate(_rotateSpeed * Time.deltaTime);
    }
}
