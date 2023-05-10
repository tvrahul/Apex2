using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropWheel : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;
    public string InteractionPropmpt => prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log(message: "Opening PropWheel");
        Application.OpenURL(" https://gameforge.com/en-US/littlegames/spinning-wheel/#");
        return true;
    }
}
