using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script2 : MonoBehaviour
{

    public Button yourButton;
    public Text demWords;
    int i;




    //	void Start () {
    //		Button btn = yourButton.GetComponent<Button>();
    //		Text script = demWords.GetComponent<Text>();
    //		btn.onClick.AddListener(TaskOnClick);
    //
    //	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            TaskOnClick();
        }
    }

    void TaskOnClick()
    {

        Text script = demWords.GetComponent<Text>();




        i += 1;
        if (i == 1)
        {
            script.text = "Mario...";
        }
        else if (i == 2)
        {
            script.text = "Mario..." +
            "...if this is you...";
        }
        else if (i == 3)
        {
            script.text = "Mario..." +
            "...if this is you..." +
            "...please leave my wife alone";
        }
        else if (i == 4)
        {
            script.text = "Mario..." +
            "...if this is you..." +
            "...please leave my wife alone..." +
            "...-King Koopa";
        }

    }
}
