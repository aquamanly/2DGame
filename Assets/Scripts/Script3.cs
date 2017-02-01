using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script3 : MonoBehaviour {

	public Button yourButton;
	public Text demWords;
	int i;
	public string beginning;
    public string middle;
	public string finale;



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
			script.text = beginning;
		} else if (i == 2) {
			script.text = beginning +
			middle;
		} else if (i == 3) {
			script.text = beginning +
            middle +
			finale;
		}
	}

}
