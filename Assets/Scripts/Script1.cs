using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script1 : MonoBehaviour {

	public Button yourButton;
	public Text demWords;
	int i;
	public GameObject Moi;
	public GameObject Walls;



//	void Start () {
//		Button btn = yourButton.GetComponent<Button>();
//		Text script = demWords.GetComponent<Text>();
//		btn.onClick.AddListener(TaskOnClick);
//
//	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.B)) {
			TaskOnClick ();
		}
	}

	void TaskOnClick(){
		
		Text script = demWords.GetComponent<Text>();



				
		i += 1;
		if (i == 1) {
			script.text = "Within this Tomb...";
		} else if (i == 2) {
			script.text = "Within this Tomb..." +
			"Lies an ancient Secret";
		} else if (i == 3) {
			script.text = "Within this Tomb..." +
			"Lies an ancient Secret" +
			" And a murder most foul...";
		}
	}

}
