using System.Collections;
using System.Collections.Generic;
using UnityEngine; // permet d'utiliser les fonctions propres à Unity agissant sur les composants Transform, Animator, rigidbody
using UnityEngine.UI; // Pour des fonctions d'éléments d'interface

public class Script1 : MonoBehaviour // classe (donne des infos et explique le comportement de l'obj) à partir de laquelle dérive tout le script
{

    int vie = 3;


    int money = 0;


    // fonctions qui héritent de la classe

    void DireBonjour()
    {
        print("Bonjour");

    }

    int Ajouter(int nb1, int nb2)
    {
        return nb1 + nb2;
    }

    void Survie()
    {
        if (vie > 0 && money==0)
        {
            print("Vivant mais pauvre");
        }
        else if (vie < 0 || money >= 5)
        {
            print("Vie plus petit que 0 ou riche");
        }
        else
        {
            print("Vie = 0");
        }

    }


    void tableau()
    {
        float[] tab = new float[6];
        // affectation de valeurs flottantes, pris au hasard entre -10 et 10, au tableau
        for (int i = 0; i < 6; i++)
        {
            tab[i] = Random.Range(-10.0f, 10.0f);
        }
    
        //affichage des valeurs du tableau
        for (int i = 0; i < 6; i++)
        {
            print(tab[i] + " ");
        }

    }


// Start is called before the first frame update
void Start() // première fct exécutée ds le jeu
    {
        DireBonjour();
        print(money);
        Survie();
        money = money + 5;
        print(money);
        Survie();

        print(Ajouter(4, 6));

     

        tableau();

    }

    // Update is called once per frame (tourne en boucle)
    void Update()
    {
        
    }
}
