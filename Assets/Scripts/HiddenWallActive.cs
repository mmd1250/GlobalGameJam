using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenWallActive : MonoBehaviour
{
    public GameObject cube;
    public GameObject HiddenWall;
    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HiddenWall.SetActive(true);
        }
    }
}
