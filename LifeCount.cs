using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCount : MonoBehaviour
{

    public Image[] lives;
    public int livesRemaining;

    //3 lives - 3 images (0, 1, 2)
    //2 lives - 2 images (0, 1, [2])

    public void LoseLife()
    {
        //if no lives - do nothing

        //decrease livesRemaining
        livesRemaining--;
        //hide life icon
        lives[livesRemaining].enabled = false;
        //0 lives -> lose game
        if(livesRemaining == 0)
        {
            Debug.Log(" You have lost ");
            SceneManager.LoadScene("DeathScreen");
        }
    }
    private void Update()
    {
        
    }
}
