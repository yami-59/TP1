using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Logs : MonoBehaviour
{
    // Déclaration d'une variable globale (compteur)
    int compteur = 0;

    // La méthode Start() est appelée une seule fois au début
    void Start()
    {
        Debug.Log("Démarrage du script Logs !");
    }

    // La méthode Update() est appelée à chaque frame (environ 60 fois par seconde)
    void Update()
    {
        compteur++;  // On incrémente le compteur
        Debug.Log("Compteur = " + compteur);
    }
}

