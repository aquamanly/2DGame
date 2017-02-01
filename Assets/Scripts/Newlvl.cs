using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Newlvl : MonoBehaviour {
    public Button newGame;
    public Scene nextlvl;
    public string lvlName;
	// Use this for initialization
	void Start () {
        Button btn = newGame.GetComponent<Button>();
        btn.onClick.AddListener(LoadScene);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadScene () {
    
        SceneManager.LoadScene(lvlName, LoadSceneMode.Single);
    }
}



