using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private Text text;
    [SerializeField] private GameObject finish;
    private bool isTimeUnderZero = false;
    
    private void Start()
    {
        time = 60;
        text = this.gameObject.GetComponent<Text>();
    }

    
    private void Update()
    {
        time -= Time.deltaTime;
        if (time > 0)
        {
            text.text = Mathf.FloorToInt(time).ToString();
        }
        else
        {
            if (!isTimeUnderZero)
            {
                time = 0;
                text.text = 0.ToString();
                finish.SetActive(true);
                isTimeUnderZero = true;
                StartCoroutine(SceneChange());
            }
        }
    }

    private IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("StartScene");
    }
}
