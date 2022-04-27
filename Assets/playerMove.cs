using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour{
    public float mainSpeed = 3.0f;//移動速度
    void Start(){
        
    }
    void Update(){
        characterMove();
    }
    /// <summary>
    /// キャラクターの移動に関するメソッド
    /// </summary>
    void characterMove(){
        Transform trans = transform;
        transform.position = trans.position;
        trans.position += trans.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * mainSpeed;
        trans.position += trans.TransformDirection(Vector3.right) * Input.GetAxis("Horizontal") * mainSpeed;
    }
}
