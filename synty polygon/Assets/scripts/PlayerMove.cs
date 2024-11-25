using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;

    public Animator animator;

    private float x, y;


    public Rigidbody rb;
    public float FuerzaDeSalto = 8f;
    public bool puedoSaltar;

    private void Start()
    {
        puedoSaltar = false;
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);
    }


    void Update()
    {
        x = Input.GetAxis("Horizontal");

        y = Input.GetAxis("Vertical");

        

        animator.SetFloat("VelX", x);

        animator.SetFloat("VelY", y);

        if(puedoSaltar)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("salte", true);
                rb.AddForce(new Vector3(0, FuerzaDeSalto, 0), ForceMode.Impulse);
            }
            animator.SetBool("tocoSuelo", true);
            
        }
        else
        {
            EstoyCayendo();
        }
    }

    public void EstoyCayendo()
    {
        animator.SetBool("tocoSuelo", true);
        animator.SetBool("salte", false);
    }
}
