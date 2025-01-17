

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject[] prefabs;
    private BoxCollider area;
    public int count = 100;
    float currTime;

    private List<GameObject> enemy = new List<GameObject>();

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 50f);
    }

    void SpawnEnemy()
    {
        area = GetComponent<BoxCollider>();

        for (int i = 0; i < count; ++i)//count �� ��ŭ �����Ѵ�
        {
            spawn();
        }

        area.enabled = false;
    }
    void spawn()
    {
        Vector3 boxCenter = area.bounds.center;
        Vector3 boxExtents = area.bounds.extents;

        float randomX = Random.Range(boxCenter.x - boxExtents.x, boxCenter.x + boxExtents.x);
        float randomZ = Random.Range(boxCenter.z - boxExtents.z, boxCenter.z + boxExtents.z);

        // �迭���� ������ prefabs�� ����
        GameObject selectedPrefab = prefabs[Random.Range(0, prefabs.Length)];

        GameObject spawnedPrefab = Instantiate(selectedPrefab);
        spawnedPrefab.transform.position = new Vector3(randomX, 0.1f, randomZ);
    }
}