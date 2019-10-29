using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    //[SerializeField] int point;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0))
        {
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider2D = Physics2D.OverlapPoint(worldPosition);

            if (collider2D)
            {
                GameObject obj = collider2D.transform.gameObject;
                string name = obj.name.Replace("(Clone)", "");
                if (name == "FakeShiitake")
                {
                    Destroy(obj);
                    manager.point -= 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(-3);
                    Debug.Log(manager.point);
                }
                if (name == "FakeNegi")
                {
                    Destroy(obj);
                    manager.point -= 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(-3);
                    Debug.Log(manager.point);
                }
                if (name == "FakeShirataki")
                {
                    Destroy(obj);
                    manager.point -= 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(-3);
                    Debug.Log(manager.point);
                }
                if (name == "FakeTouhu")
                {
                    Destroy(obj);
                    manager.point -= 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(-3);
                    Debug.Log(manager.point);
                }
                if (name == "Negi")
                {
                    Destroy(obj);
                    manager.point += 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(3);
                    Debug.Log(manager.point);
                }
                if (name == "Shiitake")
                {
                    Destroy(obj);
                    manager.point += 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(3);
                    Debug.Log(manager.point);
                }
                if (name == "Shirataki")
                {
                    Destroy(obj);
                    manager.point += 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(3);
                    Debug.Log(manager.point);
                }
                if (name == "Touhu")
                {
                    Destroy(obj);
                    manager.point += 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(3);
                    Debug.Log(manager.point);
                }
                if (name == "dumbbell")
                {
                    Destroy(obj);
                    manager.point -= 10;
                    PointChangeDisplay.Instance.DisplayChangePoint(-10);
                    Debug.Log(manager.point);
                }
                if (name == "fakeKani")
                {
                    Destroy(obj);
                    manager.point -= 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(-3);
                    Debug.Log(manager.point);
                }
                if (name == "fakeKimuchi")
                {
                    Destroy(obj);
                    manager.point -= 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(-3);
                    Debug.Log(manager.point);
                }
                if (name == "hakusai")
                {
                    Destroy(obj);
                    manager.point += 10;
                    PointChangeDisplay.Instance.DisplayChangePoint(10);
                    Debug.Log(manager.point);
                }
                if (name == "Kaeru")
                {
                    Destroy(obj);
                    manager.point -= 10;
                    PointChangeDisplay.Instance.DisplayChangePoint(-10);
                    Debug.Log(manager.point);
                }
                if (obj.name == "kani")
                {
                    Destroy(obj);
                    manager.point += 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(3);
                    Debug.Log(manager.point);
                }
                if (name == "kimuchi")
                {
                    Destroy(obj);
                    manager.point += 3;
                    PointChangeDisplay.Instance.DisplayChangePoint(3);
                    Debug.Log(manager.point);
                }
                if (name == "ninjin")
                {
                    Destroy(obj);
                    manager.point += 10;
                    PointChangeDisplay.Instance.DisplayChangePoint(10);
                    Debug.Log(manager.point);
                }
                if (name == "tomato")
                {
                    Destroy(obj);
                    manager.point += 10;
                    PointChangeDisplay.Instance.DisplayChangePoint(10);
                    Debug.Log(manager.point);
                }

            }
        }
    }
}
