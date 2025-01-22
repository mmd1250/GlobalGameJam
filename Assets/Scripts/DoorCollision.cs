using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{

    public GameObject Notif;
    public Animator DoorAnimator;
    public int DoorNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Door1 = GameObject.FindWithTag("Door");
        Animator animator1 = Door1.GetComponent<Animator>();
        GameObject Door2 = GameObject.FindWithTag("Door2");
        Animator animator2= Door2.GetComponent<Animator>();
        GameObject Door3 = GameObject.FindWithTag("Door3");
        Animator animator3= Door3.GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.E) && Notif.activeInHierarchy == true) 
        {
            if (DoorNumber == 1) 
            { 
                animator1.SetTrigger("DoorOpen");
            }
            if (DoorNumber == 2) 
            {
                animator2.SetTrigger("DoorOpen2");
            }
            if (DoorNumber == 3) 
            {
                animator3.SetTrigger("DoorOpen3");
            }
            //Notif.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door"  )
        { 
        DoorNumber = 1;
        Notif.SetActive(true);
        }
        if (other.tag == "Door2"  )
        { 
        DoorNumber = 2;
        Notif.SetActive(true);
        }
        if (other.tag == "Door3"  )
        { 
        DoorNumber = 3;
        Notif.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            Notif.SetActive(false);
        }
        if (other.tag == "Door2")
        {
            Notif.SetActive(false);
        }
        if (other.tag == "Door3")
        {
            Notif.SetActive(false);
        }

    }
}
