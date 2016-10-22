using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

    public Transform canvas;
	
	// Update is called once per frame
	void Update () {

        if (Input.acceleration.magnitude > 1.5f  || Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("space");
            if (canvas.gameObject.activeInHierarchy == false){
                Debug.Log("FALSE");
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else {
                Debug.Log("true");
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;

            }
        }
	}
}
