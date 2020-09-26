using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlock : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 1.0f)]
    private float _range;

    [SerializeField]
    GameObject[] _blocks;

    // Start is called before the first frame update
    void Start()
    {
        // ブロック配置
        _blocks[0].transform.position = new Vector3(-_range, _range, 0.0f);
        _blocks[1].transform.position = new Vector3(_range, _range, 0.0f);
        _blocks[2].transform.position = new Vector3(-_range, -_range, 0.0f);
        _blocks[3].transform.position = new Vector3(_range, -_range, 0.0f);
    }
}
