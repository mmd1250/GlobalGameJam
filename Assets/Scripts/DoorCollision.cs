using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    public int Keynumber;
    public int DoorNumber;

    public bool HasKey5 = false;
    public bool HasKey3 = false;
    public bool HasKey1 = false;
    public bool HasKey2 = false;
    public bool HasKey6 = false;
    
    //public bool keyCandestroy;
    public bool CanOpenDoor5 = false;
    public bool CanOpenDoor1 = false;
    public bool CanOpenDoor3 = false;
    public bool CanOpenDoor2 = false;
    public bool CanOpenDoor6 = false;

    public GameObject KeyNotif;
    public GameObject Notif;
    public Animator DoorAnimator;
    private GameObject Key;
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
        GameObject Door6 = GameObject.FindWithTag("Door6");
        Animator animator6= Door6.GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.E) && Notif.activeInHierarchy == true) 
        {
            if (DoorNumber == 1 && HasKey1 || CanOpenDoor1) 
            { 
                animator1.SetTrigger("DoorOpen");
                Notif.SetActive(false);
                HasKey1 = false;
                CanOpenDoor1 = true;
            }
            if (DoorNumber == 2 && HasKey2 || CanOpenDoor2) 
            {
                animator2.SetTrigger("DoorOpen2");
                Notif.SetActive(false);
                HasKey2 = false;
                CanOpenDoor2 = true;
            }
            if (DoorNumber == 3 && HasKey3 || CanOpenDoor3) 
            {
                animator3.SetTrigger("DoorOpen3");
                Notif.SetActive(false);
                HasKey3 = false;
                CanOpenDoor3 = true;
            }
            if (DoorNumber == 4) 
            {
                animator4.SetTrigger("DoorOpen4");
            }

            if (DoorNumber == 5 && HasKey5 || CanOpenDoor5) 
            {
                animator5.SetTrigger("DoorOpen5");
                Notif.SetActive(false);
                HasKey5 = false;
                CanOpenDoor5 = true;
            }
            if (DoorNumber == 6 && HasKey6 || CanOpenDoor6) 
            {
                animator6.SetTrigger("DoorOpen6");
                Notif.SetActive(false);
                HasKey6 = false;
                CanOpenDoor6 = true;
            }

            //Notif.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R) && KeyNotif.activeInHierarchy == true)
        {
            if (Keynumber == 5)
            {
                HasKey5 = true;
                Destroy(Key);
            }
            if (Keynumber == 1)
            {
                HasKey1 = true;
                Destroy(Key);
            }
            if (Keynumber == 3)
            {
                HasKey3 = true;
                Destroy(Key);
            }
            if (Keynumber == 2)
            {
                HasKey2 = true;
                Destroy(Key);
            }
            if (Keynumber == 6)
            {
                HasKey6 = true;
                Destroy(Key);
            }
            
            
            if (HasKey1 || HasKey5 || HasKey3 || HasKey6||HasKey2|| HasKey3 && Key.IsDestroyed())
            {
                KeyNotif.SetActive(false);
            }

            

           // if (Key.gameObject == null)
          //  {
           //     
            //}
            
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
        if (other.tag == "Door6"  )
        { 
        DoorNumber = 6;
        Notif.SetActive(true);
        }
        if (other.tag == "Key1")
        {
            Keynumber = 1;
            KeyNotif.SetActive(true);
            Key = other.gameObject;
        }
        if (other.tag == "Key5")
        {
            Keynumber = 5;
            KeyNotif.SetActive(true);
            Key = other.gameObject;
        }
        if (other.tag == "Key3")
        {
            Keynumber = 3;
            KeyNotif.SetActive(true);
            Key = other.gameObject;
        }
        if (other.tag == "Key2")
        {
            Keynumber = 2;
            KeyNotif.SetActive(true);
            Key = other.gameObject;
        }
        if (other.tag == "Key6")
        {
            Keynumber = 6;
            KeyNotif.SetActive(true);
            Key = other.gameObject;
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
        if (other.tag == "Door6")
        {
            Notif.SetActive(false);
        }
        if (other.tag == "Key1")
        {
            KeyNotif.SetActive(false);
        }
        if (other.tag == "Key5")
        {
            KeyNotif.SetActive(false);
        }
        if (other.tag == "Key3")
        {
            KeyNotif.SetActive(false);
        }
        if (other.tag == "Key2")
        {
            KeyNotif.SetActive(false);
        }
        if (other.tag == "Key6")
        {
            KeyNotif.SetActive(false);
        }

    }
}
