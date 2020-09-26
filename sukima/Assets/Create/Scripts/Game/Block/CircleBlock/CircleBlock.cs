using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBlock : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 1.0f)]
    private float _range;

    [SerializeField]
    GameObject[] _blocks;

    void Start()
    {
        // ブロック配置
        _blocks[0].transform.localPosition = new Vector3(0.0f, _range, 0.0f);
        _blocks[1].transform.localPosition = new Vector3(0.0f, -_range, 0.0f);
    }
}
