using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouleteTable : MonoBehaviour, IInteractable
{
    
    [SerializeField] private string prompt;
    public string InteractionPropmpt => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log(message: "Opening RouleteTable");
        Application.OpenURL("https://www.247roulette.org");
        return true;
        
    }
}
