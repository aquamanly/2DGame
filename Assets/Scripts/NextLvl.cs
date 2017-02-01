using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour {
    public Button newGame;
    public Scene nextlvl;
    public string lvlName;
	// Use this for initialization
	void Start () {
        //Button btn = newGame.GetComponent<Button>();
        //btn.onClick.AddListener(LoadScene);
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            LoadScene();
        }
    }

    public void LoadScene () {
        //Application.LoadLevel (Destination);
        SceneManager.LoadScene(lvlName, LoadSceneMode.Single);
    }
}



