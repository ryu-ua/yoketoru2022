using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 pos;
    void Start()
    {
        //�I�u�W�F�N�g�̌��݂̍��W�����
        pos = transform.position;
    }
    void Update()
    {

        float yokoyajirushi = Input.GetAxis("Horizontal");

        float ueyajirushi = Input.GetAxis("Vertical");

        pos.x += yokoyajirushi;

        pos.y += ueyajirushi;

        transform.position = pos;
    }
}
