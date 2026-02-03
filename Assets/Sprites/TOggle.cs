using UnityEngine;

public class TOggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ToggleShape()

    {

        gameObject.SetActive(!gameObject.activeInHierarchy);    
        //ameObject.SetActive(false);

        ////if the gmae object is inactive (turned off): call SetActive passing truef
        //if (gameObject.activeInHierarchy == false)

        //{
        //    gameObject.SetActive(false);
        //}

        //else if (gameObject.activeInHierarchy == true)
        //{
        //    //otherwise (the game object is active, turned on): call SetActive and pass false
        //    gameObject.SetActive(false) ;
        }
    }

