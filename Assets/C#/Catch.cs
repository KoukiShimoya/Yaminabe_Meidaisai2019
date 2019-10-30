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

    private class GameObjectBool
    {
        [CanBeNull] public GameObject gameObject;
        public bool left_right;

        public GameObjectBool(GameObject gameObject, bool left_right)
        {
            this.gameObject = gameObject;
            this.left_right = left_right;
        }
    }

    private GameObjectBool ReturnIngredientsWhileShaking()
    {
        if (getJoyconValue.IsOverGyroThreshould(true, 15))
        {
            if (enterObject != null)
            {
                return new GameObjectBool(enterObject, true);
            }
            return new GameObjectBool(null, true);
        }
        
        if (getJoyconValue.IsOverGyroThreshould(false, 15))
        {
            if (enterObject != null)
            {
                return new GameObjectBool(enterObject, false);
            }
            return new GameObjectBool(null, false);
        }
        
        return new GameObjectBool(null, false);
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
        GameObjectBool shakeAndEnterObject = ReturnIngredientsWhileShaking();
        
        if (shakeAndEnterObject.gameObject != null)
        {
            GameObject obj = shakeAndEnterObject.gameObject;
            string name = obj.name.Replace("(Clone)", "");
            if (name == "FakeShiitake")
            {
                Destroy(obj);
                manager.point -= 3;
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "FakeNegi")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "FakeShirataki")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "FakeTouhu")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "Negi")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Shiitake")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Shirataki")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Touhu")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "dumbbell")
            {
                Destroy(obj);
                manager.point -= 10;
                PointChangeDisplay.Instance.DisplayChangePoint(-10);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "fakeKani")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "fakeKimuchi")
            {
                Destroy(obj);
                manager.point -= 3;
                PointChangeDisplay.Instance.DisplayChangePoint(-3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (name == "hakusai")
            {
                Destroy(obj);
                manager.point += 10;
                PointChangeDisplay.Instance.DisplayChangePoint(10);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "Kaeru")
            {
                Destroy(obj);
                manager.point -= 10;
                PointChangeDisplay.Instance.DisplayChangePoint(-10);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 300);
                AudioClipCreate.Instance.SoundOn(false);
                Debug.Log(manager.point);
            }

            if (obj.name == "kani")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "kimuchi")
            {
                Destroy(obj);
                manager.point += 3;
                PointChangeDisplay.Instance.DisplayChangePoint(3);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "ninjin")
            {
                Destroy(obj);
                manager.point += 10;
                PointChangeDisplay.Instance.DisplayChangePoint(10);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }

            if (name == "tomato")
            {
                Destroy(obj);
                manager.point += 10;
                PointChangeDisplay.Instance.DisplayChangePoint(10);
                getJoyconValue.SetJoyconRumble(shakeAndEnterObject.left_right, 0.6f, 80);
                AudioClipCreate.Instance.SoundOn(true);
                Debug.Log(manager.point);
            }
        }
    }
}