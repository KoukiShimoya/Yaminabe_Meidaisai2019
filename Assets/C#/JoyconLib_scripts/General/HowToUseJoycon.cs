using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToUseJoycon : MonoBehaviour
{
    private GetJoyconValue getJoyconValue;
    private void Start()
    {
        getJoyconValue = GetJoyconValue.Instance;
    }
    
    void Usage()
    {
        //左Joyconの加速度を取得
        getJoyconValue.GetJoyconAcceleration(true);
        //右Joyconの加速度を取得
        getJoyconValue.GetJoyconAcceleration(false);
        
        //左Joyconの角加速度を取得
        getJoyconValue.GetJoyconGyro(true);
        //左Joyconのアナログスティックを取得
        getJoyconValue.GetJoyconStick(true);
        //左Joycon本体の傾きを取得
        getJoyconValue.GetJoyconVector(true);
        
        //左Joyconの振った量がしきい値を超えたかどうか
        getJoyconValue.IsOverGyroThreshould(true, 10);
        
        //左JoyConを振動させる
        getJoyconValue.SetJoyconRumble(true, 0.6f,200);
        
        //左JoyConの押したボタンを取得
        getJoyconValue.PressedButton(true);
    }
}
