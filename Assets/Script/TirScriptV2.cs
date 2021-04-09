using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // permet d'utiliser des fcts propres aux élts d'interface


public class TirScriptV2 : MonoBehaviour
{
    public int nbShotsLeft = 5; // nb de coups restants
    int power = 1000; // puissance de tir
    public GameObject balle; // la balle
    public Text txtNbShots; // Text nb coups, type Text spécifique à l'UI
    public Text txtPower; // Text puissance
    public Slider slider; // varialble % slider


    public void Shoot() // fonction de tir (déclenchée lors du clic souris)
    {
        if (nbShotsLeft > 0) // s'il reste des coups
        {
            nbShotsLeft--; // décrémentation du nb de coups
            txtNbShots.text = "Shots:" + nbShotsLeft; // modification du texte

            balle.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * power); // on tire la balle

            // ajout d'une force au Rigidbody de la balle qui prend un vecteur en param indiquant la direction et la force
            // Camera.main: accès à la cam principale
            // transform.forward: vecteur indiquant la direction devant la cam
        }
    }

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
}