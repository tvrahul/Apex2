using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionPropmpt => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log(message : "Opening SlotMachine");
        Application.OpenURL("https://www.addictinggames.com/strategy/yummy-slot-machine");
        return true;
    }
}
