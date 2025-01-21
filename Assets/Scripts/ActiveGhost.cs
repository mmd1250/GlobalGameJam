using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGhost : MonoBehaviour
{
    public GameObject cube;
    public GameObject ghost;
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
        if (other.gameObject.CompareTag("Player")) 
        {
            ghost.SetActive(true);
        }
    }
}
