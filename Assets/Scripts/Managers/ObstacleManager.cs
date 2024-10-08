using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] int createCount = 5;
    [SerializeField] int random;
    [SerializeField] List<GameObject> obstacleList;

    void Start()
    {
        obstacleList.Capacity = 20;

        Create();
    }

    public void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject clone = ResourcesManager.Instance.Instantiate("Cone", gameObject.transform);

            clone.SetActive(false);

            obstacleList.Add(clone);

        }
    }

    public bool ExamineActive()
    {
        for (int i = 0; i < obstacleList.Count; i++)
        {
            if (obstacleList[i].activeSelf == false)
            {
                return false;
            }
        }

        return true;
    }

    public GameObject GetObstacle()
    {
        return obstacleList[random];
    }
}