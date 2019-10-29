using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guzai : MonoBehaviour
{
    public float dx=100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 nowPosition = this.transform.position;
        Vector2 nextPosition;
        nextPosition.x = nowPosition.x;
        nextPosition.y = nowPosition.y + 0.1f;
        this.transform.position = nextPosition;
        if (nextPosition.y > 10)
        {
            Destroy(this.gameObject);
        }
    }
}
