using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETtest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Click);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Get);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TinyAudio.PlaySE(TinyAudio.SE.miss);
        }
    }
}
