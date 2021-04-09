using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject menuPause; // Le menu pause (panel)

    /*
    public void ChangeState()
    {
        if (true == menuPause.activeInHierarchy) //Si l'objet est actif
        {
            menuPause.SetActive(false);	//alors on le désactive
        }
        else  //Sinon (donc il est inactif)
        {
            gameObject.SetActive(true); //alors on l'active
        }
    }*/

    public void ActivatePause() // La fonction de mise en pause
    {
        menuPause.SetActive(true); // activation du menu pause
        Time.timeScale = 0.0f; // On arrête le temps
    }

    // Retour au jeu
    public void DesactivatePause()
    {
        menuPause.SetActive(false); // On désactive le menu pause
        Time.timeScale = 1.0f; // On met le temps à 1
    }
    
    // Recharger le niveau
    public void Reload()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Retour au menu
    public void BackToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0); // charger la scene 0 (menu)
    }

    //charger le niveau suivant
    
    /*public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/
    
    
    


}
