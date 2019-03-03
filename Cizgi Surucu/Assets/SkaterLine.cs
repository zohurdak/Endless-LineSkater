using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkaterLine : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            animator.SetBool("ismouseup", true);
        }

    }



}