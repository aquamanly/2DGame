using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collide : MonoBehaviour {
    
    public GameObject Speakin;

    void Start()
    {

    }
void Update()
    {


    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        Speakin.SetActive(true);
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        Speakin.SetActive(false);
    }
}
