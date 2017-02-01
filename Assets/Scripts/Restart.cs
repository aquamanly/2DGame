using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    public string lvlName;
    

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        
        SceneManager.LoadScene(lvlName, LoadSceneMode.Single);
    }
}
