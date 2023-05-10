using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;





public class MenuManager : MonoBehaviour
{
    public GameObject settingMenu;
    public bool isSettingMenuActive = false;    

    public GameObject settingBtn;
    public GameObject customizationBtn;
    public GameObject playerFollowCamera;

    private ThirdPersonController controller;

    public GameObject Player;
  
   
   
    

   
    

    

    // Start is called before the first frame update
   void Start() {
    controller = Player.GetComponent<ThirdPersonController>();
   }

   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle the setting menu active state
            isSettingMenuActive = !isSettingMenuActive;

            // Set the setting menu object active state
            settingMenu.SetActive(isSettingMenuActive);

            //Pause the game if the setting menu is active
            Time.timeScale = isSettingMenuActive ? 0 : 1;

            playerFollowCamera.SetActive(!isSettingMenuActive);
            
            settingBtn.SetActive(!isSettingMenuActive);
            customizationBtn.SetActive(!isSettingMenuActive);

            controller.enabled = !isSettingMenuActive;

           
             

           
        }
       

       
    }
}
