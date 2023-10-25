using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject player;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        //CHANGE THIS IF PLAYER NAME CHANGED!!!!!!!!!
        player = GameObject.Find("test_dash"); //THIS MUST BE CHANGED IF NAME OF PLAYER VARIABLE IS CHANGED
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
