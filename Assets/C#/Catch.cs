using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Catch : MonoBehaviour
{
    private GetJoyconValue getJoyconValue;

    [CanBeNull] private GameObject enterObject;

    private void Start()
    {
        getJoyconValue = GetJoyconValue.Instance;
    }

    private GameObject ReturnIngredientsWhileShaking()
    {
        if (!getJoyconValue.IsOverGyroThreshould(true, 20) && !getJoyconValue.IsOverGyroThreshould(false, 20))
        {
            return null;
        }

        if (enterObject != null)
        {
            return enterObject;
        }
        else
        {
            return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        enterObject = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        enterObject = null;
    }

    void Update()
    {
        GameObject shakeAndEnterObject = ReturnIngredientsWhileShaking();
        
        if (shakeAndEnterObject != null)
        {
            GameObject obj = shakeAndEnterObject;
            string name = obj.name.Replace("(Clone)", "");
            if (name == "FakeShiitake")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "FakeNegi")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "FakeShirataki")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "FakeTouhu")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "Negi")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Shiitake")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Shirataki")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Touhu")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "dumbbell")
            {
                Destroy(obj);
                manager.point -= 10;
                PointChangeDisplay.Instance.DisplayChangePoint(-10);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "fakeKani")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "fakeKimuchi")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "hakusai")
            {
                Destroy(obj);
                manager.point += 10;
                PointChangeDisplay.Instance.DisplayChangePoint(10);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Kaeru")
            {
                Destroy(obj);
                manager.point -= 10;
                PointChangeDisplay.Instance.DisplayChangePoint(-10);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (obj.name == "kani")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "kimuchi")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "ninjin")
            {
                Destroy(obj);
                manager.point += 10;
                PointChangeDisplay.Instance.DisplayChangePoint(10);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "tomato")
            {
                Destroy(obj);
                manager.point += 10;
                PointChangeDisplay.Instance.DisplayChangePoint(10);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }
        }
    }
}