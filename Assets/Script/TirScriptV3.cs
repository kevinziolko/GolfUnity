using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // permet d'utiliser des fcts propres aux élts d'interface


public class TirScriptV3 : MonoBehaviour
{
    public int nbShotsLeft = 5; // nb de coups restants
    public int power = 1000; // puissance de tir
    public GameObject balle; // la balle
    public Text txtNbShots; // Text nb coups, type Text spécifique à l'UI
    public Text txtPower; // Text puissance
    public Slider slider; // varialble % slider
    public AudioClip son; // variable pr stocker un son

    private void start()
    {
        txtNbShots.text = "Shots:" + nbShotsLeft; // affichage du nombre de coups
    }

    public void SetShotPower() // définir texte puissance
    {
        // On récupère et convertit la valeur
        int val = (int)slider.value;
        txtPower.text = val + "%";

    }


    public void Shoot() // fonction de tir (déclenchée lors du clic souris)
    {
        
        if (nbShotsLeft > 0) // s'il reste des coups
        {
            power = (int)slider.value * 25; // Nous récupérons la valueur du slider pour la puissance, puis *25 pr avoir une puiss suffisante

            balle.GetComponent<AudioSource>().PlayOneShot(son); // on ajoute l'audio

            nbShotsLeft--; // décrémentation du nb de coups
            txtNbShots.text = "Shots:" + nbShotsLeft; // modification du texte

            balle.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * power); // on tire la balle
                            // ajout d'une force au Rigidbody de la balle qui prend un vecteur en param indiquant la direction et la force
                            // Camera.main: accès à la cam principale
                            // transform.forward: vecteur indiquant la direction devant la cam


            slider.value = 0; // on réinitialise la puissance à 0 (car le slider conserve la dernière valeur définie)
            StartCoroutine("LockSlider"); // appel de la coroutine
        }
    }

   

    

    IEnumerator LockSlider() // coroutine: fonction qui permet de mettre en pause. Permet de locker le slider de tir, après un délai,
                             // jusqu'à ce que la balle s'arrête
    {
        yield return new WaitForSeconds(0.2f); // 0,2s après le tir
        slider.interactable = false; // On blque le slider après le tir
    }

    private void Update()
    {
        // Si la vitesse balle faible et slider bloqué
        if(balle.GetComponent<Rigidbody>().velocity.magnitude < 0.2f && slider.interactable == false)
        {

            slider.interactable = true; // on active de nouveau le slider
        }
    }
}