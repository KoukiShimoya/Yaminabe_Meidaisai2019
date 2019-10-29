using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointDisplay : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        text.text = manager.point.ToString();
    }
}
