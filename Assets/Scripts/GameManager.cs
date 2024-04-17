using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Valve.VR;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool selection_trash1 = false;
    public bool selection_trash2 = false;
    public bool selection_trash3 = false;
    public bool selection_trash4 = false;
    public bool selection_trash5 = false;
    public AudioSource source;



    private void Awake()
    {
        instance = this;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash1"))
        {
            selection_trash1 = true;
        }
         
        if (other.CompareTag("Trash2"))
        {
            selection_trash2 = true;
        }

        if (other.CompareTag("Trash3"))
        {
            selection_trash3 = true;
        }

        if (other.CompareTag("Trash4"))
        {
            selection_trash4 = true;
        }

        if (other.CompareTag("Trash5"))
        {
            selection_trash5 = true;
        }

        if ((selection_trash1 == true) && (selection_trash2 == true) && (selection_trash3 == true) && (selection_trash4 == true) && (selection_trash5 == true))
        {
            print("Мусор убран");
        }
    }

}