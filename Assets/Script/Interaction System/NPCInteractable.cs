using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    
    
  

    public Animator animator;

   
   

    public void Interact()
    {
        animator.SetTrigger("Talk");
    }


}

