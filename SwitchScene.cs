using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public int nextSceneBuildIndex;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");

        if(other.tag == "Player"){
            SceneManager.LoadScene(nextSceneBuildIndex, LoadSceneMode.Single);
        }
    }
    
}
