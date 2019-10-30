using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiate : MonoBehaviour
{
    [SerializeField] private List<GameObject> itemList;
    private void Start()
    {
        StartCoroutine(ItemInstantiate());
    }

    private IEnumerator ItemInstantiate()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Debug.Log("Instantiate");
            GameObject item = itemList[UnityEngine.Random.Range(0, itemList.Count)];
            GameObject instantiatedItem = Instantiate(item);
            Vector2 position = instantiatedItem.transform.localPosition;
            position.x = UnityEngine.Random.Range(-3.0f, 1.0f);
            position.y = 0;
            instantiatedItem.transform.localPosition = position;
            instantiatedItem.GetComponent<SpriteRenderer>().sortingOrder = UnityEngine.Random.Range(2, 4);
        }
    }
}
