using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    float inputx;
    float inputy;
    Vector3 playermotor;
    Animator anim;
    float maxlong;
    float rotatespeed;
    float speed=2;

    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputy = Input.GetAxis("Vertical");
        movemotor();
        rotaremotor();
    }
    public void movemotor()
    {
        anim.SetFloat("Horizontal",inputx);
        anim.SetFloat("Vertical", inputy);
        playermotor = new Vector3(inputx,0,inputy) *Time.deltaTime*speed;
        transform.position += playermotor;
    }
    public void rotaremotor()
    {

    }
}
