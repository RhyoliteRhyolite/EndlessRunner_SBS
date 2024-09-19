using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] List<GameObject> roads;

    private void Start()
    {
        roads.Capacity = 10;
    }

    // Start is called before the first frame update
    private void Update()
    {
        for (int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
