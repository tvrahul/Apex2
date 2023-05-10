using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;


public class SettingsMenu : MonoBehaviour
{
    public GameObject SettingUICard;
    public GameObject SettingIcon;
    public GameObject MenuIcon;

    public GameObject  playerFollowCamera;

    private ThirdPersonController controller;

    public GameObject Player;

    public bool IsShow = false;
    /// <summary>
    /// This method use to show and hide Setting menu
    /// https://app.asana.com/0/0/1203960778002698/f
    /// 20-02-2023
    /// </summary>
    /// <param name="IsShow"></param>

    void Start()
    {
        controller = Player.GetComponent<ThirdPersonController>();
    }
    public void ShowSettingMenu(bool IsShow)
    {
        if(IsShow == true)
        {
           
            SettingUICard.SetActive(true);
            SettingIcon.SetActive(false);
            MenuIcon.SetActive(false);

             //Pause the game if the setting menu is active
            Time.timeScale = 0;

            playerFollowCamera.SetActive(false);
            controller.enabled = false;

            
           
        }
        else if (IsShow == false)
        {
            
            SettingUICard.SetActive(false);
            SettingIcon.SetActive(true);
            MenuIcon.SetActive(true);

            Time.timeScale = 1;
            

            playerFollowCamera.SetActive(true);
            controller. enabled = true;

           
        }
    }

}
