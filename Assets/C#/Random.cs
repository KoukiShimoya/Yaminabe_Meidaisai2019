using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    float time;
    [SerializeField] GameObject FakeShiitake;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 10)
        {
            time = 0;
            GameObject createdShiitake = Instantiate(FakeShiitake);
            Vector3 position = createdShiitake.transform.position;
            position.x= UnityEngine.Random.Range(-2,2);
            createdShiitake.transform.position = position;

        }
    }
}
