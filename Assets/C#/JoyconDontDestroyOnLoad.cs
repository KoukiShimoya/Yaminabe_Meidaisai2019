using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyconDontDestroyOnLoad : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
