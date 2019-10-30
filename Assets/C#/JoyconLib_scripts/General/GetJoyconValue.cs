using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GetJoyconValue : SingletonMonoBehaviour<GetJoyconValue>
{
    private JoyconManager joyconManager;
    private Joycon joyconL;
    private Joycon joyconR;
    private static readonly Joycon.Button[] m_buttons =
        Enum.GetValues( typeof( Joycon.Button ) ) as Joycon.Button[];
    private Joycon.Button?  pressedButtonL;
    private Joycon.Button?  pressedButtonR;

    private void Start()
    {
        joyconManager = JoyconManager.Instance;
        joyconL = joyconManager.j.Find( c =>  c.isLeft );
        joyconR = joyconManager.j.Find(c => !c.isLeft);
    }

    private void Update()
    {
        pressedButtonL = null;
        pressedButtonR = null;
        
        foreach ( var button in m_buttons )
        {
            if ( joyconL.GetButton( button ) )
            {
                pressedButtonL = button;
            }
            if ( joyconR.GetButton( button ) )
            {
                pressedButtonR = button;
            }
        }
    }
    
    /// <summary>
    /// Joyconの加速度を取得
    /// </summary>
    /// <param name="LorR">Lならtrue, Rならfalse</param>
    /// <returns></returns>
    public Vector3 GetJoyconAcceleration(bool LorR)
    {
        return LorR ? joyconL.GetAccel() : joyconR.GetAccel();
    }
    
    /// <summary>
    /// Joyconのジャイロを取得
    /// </summary>
    /// <param name="LorR">Lならtrue, Rならfalse</param>
    /// <returns></returns>
    public Vector3 GetJoyconGyro(bool LorR)
    {
        return LorR ? joyconL.GetGyro() : joyconR.GetGyro();
    }
    
    /// <summary>
    /// Joyconのアナログスティックの傾き
    /// </summary>
    /// <param name="LorR">Lならtrue, Rならfalse</param>
    /// <returns></returns>
    public Vector2 GetJoyconStick(bool LorR)
    {
        return LorR
            ? new Vector2(joyconL.GetStick()[0], joyconL.GetStick()[1])
            : new Vector2(joyconR.GetStick()[0], joyconR.GetStick()[1]);
    }
    
    /// <summary>
    /// Joycon自体の傾き
    /// </summary>
    /// <param name="LorR">Lならtrue, Rならfalse</param>
    /// <returns></returns>
    public Vector3 GetJoyconVector(bool LorR)
    {
        return LorR ? joyconL.GetVector().eulerAngles : joyconR.GetVector().eulerAngles;
    }

    /// <summary>
    /// Joyconの振った量がしきい値を超えたかどうか
    /// </summary>
    /// <param name="LorR">Lならtrue, Rならfalse</param>
    /// <param name="thresould">しきい値</param>
    /// <returns></returns>
    public bool IsOverGyroThreshould(bool LorR, float thresould)
    {
        return GetJoyconGyro(LorR).magnitude > thresould;
    }

    /// <summary>
    /// Joyconの押しているボタンを返す, null許容型
    /// </summary>
    /// <param name="LorR">Lならtrue, Rならfalse</param>
    /// <returns></returns>
    public Joycon.Button? PressedButton(bool LorR)
    {
        return LorR ? pressedButtonL : pressedButtonR;
    }

    /// <summary>
    /// Joyconを振動させる
    /// </summary>
    /// <param name="LorR">Lならtrue, Rならfalse</param>
    /// <param name="lowFrequency">最小振動周波数</param>
    /// <param name="highFrequency">最大振動周波数</param>
    /// <param name="amp"></param>
    /// <param name="time">ミリ秒</param>
    public void SetJoyconRumble(bool LorR, float amp, int time, float lowFrequency = 160f, float highFrequency = 320f)
    {
        if (LorR)
        {
            joyconL.SetRumble(lowFrequency, highFrequency, amp, time);
        }
        else
        {
            joyconR.SetRumble(lowFrequency, highFrequency, amp, time);
        }
    }
    
}
