/***
 * Author: Betzaida Ortiz Rivas
 * Created: 10-19-22
 * Modified:
 * Description: Open door on trigger
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{

    public GameObject doorObject;
    Animator animator; //reference to animator
    public string animParam; //reference to the animator parameter

    // Start is called before the first frame update
    void Start()
    {
        animator = doorObject.GetComponent<Animator>();
        Debug.Log(animator.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool(animParam, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
      if(other.tag == "Player")
        {
            animator.SetBool(animParam, false);
        }
    }
}
