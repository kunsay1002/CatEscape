﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // フレームごとに等速で落下させる
        transform.Translate(0, -0.1f, 0);

        // 画面外に出たらオブジェクトを破棄する
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
        
    }
}
