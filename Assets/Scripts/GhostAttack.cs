using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GhostAttack : MonoBehaviour
{
    public Animator Ghost_Animator;
    public float Dis;

    public GameObject Player;
    public GameObject Ghost;
    public bool HasAttacked = false; // ??? ???? ????? ???????
    public bool CanAttack = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dis = Vector3.Distance(Player.transform.position, Ghost.transform.position);
        if (Dis < 3 && !HasAttacked && CanAttack)
        {
            Ghost_Animator.SetTrigger("Attack");
            HasAttacked = true;
            CanAttack = false;
        }
        
        if (Dis > 3 && HasAttacked && !CanAttack)
            {
                //ResetTrigger(); // ???????? ??? ???? ????? ????? ?? ? ??
                HasAttacked = false;
                CanAttack = true;
            }
    }
    private void ResetTrigger()
    {
        HasAttacked = false;//???? ???? ??? ?? ?????? 
    }
}
