using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    public GameObject KeyNotif;
    public GameObject Notif;
    public Animator DoorAnimator;
    public int DoorNumber;
    public bool HasKey = false;
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
        GameObject Door4 = GameObject.FindWithTag("Door4");
        Animator animator4= Door4.GetComponent<Animator>();
        GameObject Door5 = GameObject.FindWithTag("Door5");
        Animator animator5= Door5.GetComponent<Animator>();
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
            if (DoorNumber == 4) 
            {
                animator4.SetTrigger("DoorOpen4");
            }

            if (DoorNumber == 5 && HasKey) 
            {
                animator5.SetTrigger("DoorOpen5");
            }

            //Notif.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R) && KeyNotif.activeInHierarchy == true)
        {
            HasKey = true;
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
        if (other.tag == "Door4"  )
        { 
        DoorNumber = 4;
        Notif.SetActive(true);
        }
        if (other.tag == "Door5"  )
        { 
        DoorNumber = 5;
        Notif.SetActive(true);
        }
        if (other.tag == "Key")
        {
            KeyNotif.SetActive(true);
            if (HasKey == true)
            {
                Destroy(other.gameObject);
            }
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
        if (other.tag == "Door4")
        {
            Notif.SetActive(false);
        }
        if (other.tag == "Door5")
        {
            Notif.SetActive(false);
        }
        if (other.tag == "Key")
        {
            KeyNotif.SetActive(false);
        }

    }
}
