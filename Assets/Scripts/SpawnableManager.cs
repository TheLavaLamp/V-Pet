using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnableManager : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    [SerializeField]
    GameObject spawnablePrefab;
    Camera arCam;
    GameObject spawnedObject;
    GameObject spawnedBug;
    bool petSpawned;
    private List<GameObject> spawnedPrefabList = new List<GameObject>();

    private int maxPrefabSpawnCount = 1;
    private int spawnedPrefabCount;

    // Start is called before the first frame update
    void Start()
    {
        spawnedObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
        petSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 0)
            return;

        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);

        if(m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits))
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began && spawnedObject == null)
            {
                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.collider.gameObject.tag == "Insect")
                    {
                        spawnedObject = hit.collider.gameObject;
                    }
                    else if(hit.collider.gameObject.tag == "Pet")
                    {
                        Debug.Log("Pet");
                    }
                    else if (spawnedPrefabCount < maxPrefabSpawnCount)
                    {
                        SpawnPrefab(m_Hits[0].pose.position);
                    }
                }
            }
            else if(Input.GetTouch(0).phase == TouchPhase.Moved && spawnedObject != null)
            {
                spawnedObject.transform.position = m_Hits[0].pose.position;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                spawnedObject = null;
            }
        }
    }

    private void SpawnPrefab(Vector3 spawnPosition)
    {
        spawnedObject = Instantiate(spawnablePrefab, spawnPosition, Quaternion.identity);
        //make the pet face AR camera
        spawnedObject.transform.LookAt(arCam.transform.position);
        //count spawned prefabs so count does not go over limit
        spawnedPrefabCount++;
        //pet is spawned, no need to spawn more
        //petSpawned = true;
    }

    public void SetPrefabType(GameObject spawnableBug)
    {
        spawnablePrefab = spawnableBug;
        maxPrefabSpawnCount = 11;
    }
}
