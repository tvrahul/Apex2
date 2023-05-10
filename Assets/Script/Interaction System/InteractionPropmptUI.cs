using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPropmptUI : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField] private GameObject uiPanel;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        uiPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var rotation = mainCamera.transform.rotation;
        transform.LookAt(worldPosition: transform.position + rotation * Vector3.forward, worldUp: rotation * Vector3.up);
        
    }

    public bool IsDisplayed = false;

    public void SetUp()
    {
        uiPanel.SetActive(true);
        IsDisplayed = true;
    }

    public void Close()
    {
        uiPanel.SetActive(false);
        IsDisplayed = false;
    }
}
