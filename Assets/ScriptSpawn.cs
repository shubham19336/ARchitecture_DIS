using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlaceIndiRing placementIndicator;
    private bool house = false;

    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<PlaceIndiRing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (house==false)
            {
                GameObject obj = Instantiate(objectToSpawn,
                    placementIndicator.transform.position, placementIndicator.transform.rotation);
                objectToSpawn.SetActive(true);
                house = true;
            }
                

        }
    }
}
