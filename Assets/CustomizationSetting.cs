using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationSetting : MonoBehaviour
{
    public GameObject characterCustomization;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCustomizationMenu()
    {
        characterCustomization.SetActive(true);
    }

    public void BackToGameScene()
    {
        characterCustomization.SetActive(false);
    }
}
