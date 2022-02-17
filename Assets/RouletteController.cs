using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //回転速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら回転速度を設定する
        if(Input.GetMouseButtonDown(0)) //一度だけ「true」を返す
                                        //GetMouseButtonUp:マウスボタンが離されたとき「true」
                                        //GetMouseButton:マウスがクリックされている間はずっと「true」
        {
            this.rotSpeed = 10;
        }

        //回転速度分、ルーレットを回転させる(フレームごとに10度回転)
        transform.Rotate(0, 0, this.rotSpeed); //現在の角度から引数に与えた量だけ回転する

        //ルーレットを減速させる
        this.rotSpeed *= 0.96f;

    }
}
