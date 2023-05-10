using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionRadius = 0.5f;
    [SerializeField] private LayerMask interactableMask;
    [SerializeField] private InteractionPropmptUI interactionPropmptUI;

    private readonly Collider[] colliders  = new Collider[3];
    [SerializeField] private int numFound;

    private IInteractable interactable;

    public Animator animator;






    private void Update() {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionRadius, colliders, interactableMask);
        if(numFound > 0 )
        {
             interactable = colliders[0].GetComponent<IInteractable>();
            



            if (interactable != null )
            {
                
                if (!interactionPropmptUI.IsDisplayed) interactionPropmptUI.SetUp();
                animator.SetTrigger("Talk");
                


            }
            if (Input.GetKeyDown(KeyCode.E)) interactable.Interact(this);

           

        }
        else
        {
            if(interactable != null) interactable = null;
            if (interactionPropmptUI.IsDisplayed) interactionPropmptUI.Close();
        }
    }


   
    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionRadius);
        
    }

   
}
