using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject prefabs;
    private BoxCollider area;
    public int count = 100;
    // �ð��� ����� ������ �ϳ� ������ش�.

    
    void Start()
    {
        area = GetComponent<BoxCollider>();

        for (int i = 0; i < count; ++i)//count �� ��ŭ �����Ѵ�
        {
            spawn();//���� + ������ġ�� �����ϴ� �Լ�
        }

        area.enabled = false;
    }

    public void spawn()
    {
            Vector3 boxCenter = area.bounds.center;
            Vector3 boxExtents = area.bounds.extents;

            float randomX = Random.Range(boxCenter.x - boxExtents.x, boxCenter.x + boxExtents.x);

            float randomZ = Random.Range(boxCenter.z - boxExtents.z, boxCenter.z + boxExtents.z);


            prefabs = Instantiate(prefabs);

            // �ҷ��� ������Ʈ�� �����ϰ� ������ ��ǥ������ ��ġ�� �ű��.
            prefabs.transform.position = new Vector3(randomX, 0.1f, randomZ);
    }

    
}
