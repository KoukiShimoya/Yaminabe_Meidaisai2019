using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PressToStart : MonoBehaviour
{
    private float scaleMin = 0.8f;

    private float scaleMax = 1.0f;

    private bool down = true;
    
    private void Update()
    {
        Vector3 scale = this.gameObject.transform.localScale;
        if (down)
        {
            scale.x -= 0.007f;
            scale.y -= 0.007f;

            if (scale.x < scaleMin)
            {
                down = false;
            }
            else
            {
                this.gameObject.transform.localScale = scale;
            }
        }
        else
        {
            scale.x += 0.007f;
            scale.y += 0.007f;

            if (scale.x > scaleMax)
            {
                down = true;
            }
            else
            {
                this.gameObject.transform.localScale = scale;
            }
        }
    }

    public void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
