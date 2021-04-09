using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // vitesse du scrolling (C#: mettre f pour les float)
    Renderer rend; // Le composant Renderer (acc�s au mat�rial)

    // Start is called before the first frame update
    void Start()  // se d�clenche au lancement du jeu
    {
        rend = GetComponent<Renderer>(); // fonct qui va chercher le composant (r�f�rence vers le renderer) sur le champ de force 
    }

    // Update is called once per frame
    void Update() // tourne en 60 images/sec
    {
        // change la valeur en fonction du tps
        float offset = Time.time * scrollSpeed;
        // modifie la valeur de offset
        rend.material.mainTextureOffset = new Vector2(offset, offset/3);
    }
}
