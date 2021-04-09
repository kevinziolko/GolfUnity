using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirScript : MonoBehaviour
{
    public int nbShotsLeft = 5; // nb de coups restants
    int power = 1000; // puissance de tir
    public GameObject balle; // la balle

    public void Shoot() // fonction de tir (d�clench�e lors du clic souris)
    {
        if (nbShotsLeft > 0) // s'il reste des coups
        {
            nbShotsLeft--; // d�cr�mentation du nb de coups
            balle.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * power); // on tire la balle

            // ajout d'une force au Rigidbody de la balle qui prend un vecteur en param indiquant la direction et la force
            // Camera.main: acc�s � la cam principale
            // transform.forward: vecteur indiquant la direction devant la cam
        }
    }
}


