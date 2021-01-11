using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destination : MonoBehaviour
{
    public GameObject finishScreen;
    bool isGameDone = false;
    GameObject player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

   
    void Update()
    {
        StartGameAgain();
    }

    void OnTriggerStay(Collider collider) {
        if (collider.gameObject.tag == "Player" && Vector2.Distance(transform.position, player.transform.position) < 4){
            finishScreen.SetActive(true);
            isGameDone = true;
            

        }
    }

    void StartGameAgain(){
        if (Input.GetKeyDown(KeyCode.Space) && isGameDone){
            SceneManager.LoadScene("SampleScene");
        }

    }
}
