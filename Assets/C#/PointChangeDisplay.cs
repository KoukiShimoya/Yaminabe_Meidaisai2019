using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointChangeDisplay : SingletonMonoBehaviour<PointChangeDisplay>
{
    private Text text;
    private RectTransform rect;
    private int yMin = -42;
    private int yMax = 162;
    
    private void Start()
    {
        text = this.gameObject.GetComponent<Text>();
        rect = this.gameObject.GetComponent<RectTransform>();
    }

    public void DisplayChangePoint(int point)
    {
        text.text = point.ToString();
        Vector2 position = rect.anchoredPosition;
        position.y = yMin;
        rect.anchoredPosition = position;
        StartCoroutine(PointPositionUp());
    }

    private IEnumerator PointPositionUp()
    {
        Vector2 position;
        while (rect.anchoredPosition.y < yMax)
        {
            position = rect.anchoredPosition;
            position.y += 4;
            rect.anchoredPosition = position;
            yield return null;
        }
        
        position = rect.anchoredPosition;
        position.y = yMin;
        rect.anchoredPosition = position;
        text.text = "";
        yield break;
    }
}
