using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject prefabs;
    private BoxCollider area;
    public int count = 100;
    // 시간을 담당할 변수를 하나 만들어준다.

    
    void Start()
    {
        area = GetComponent<BoxCollider>();

        for (int i = 0; i < count; ++i)//count 수 만큼 생성한다
        {
            spawn();//생성 + 스폰위치를 포함하는 함수
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

            // 불러온 오브젝트를 랜덤하게 생성한 좌표값으로 위치를 옮긴다.
            prefabs.transform.position = new Vector3(randomX, 0.1f, randomZ);
    }

    
}
