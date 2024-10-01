using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public GameObject lobbyUI;
   public void StartGame()
   {
        lobbyUI.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
   }

   public void QuitGame()
   {
        Application.Quit();
   }
}
