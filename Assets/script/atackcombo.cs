using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atackcombo : MonoBehaviour
{
    Animator anim;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("attack",true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("attack",false);

        }

    }
}


