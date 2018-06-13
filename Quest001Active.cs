using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Active : MonoBehaviour {

	// Use this for initialization
	void Start () { }


    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox;

    public GameObject QuestItemToClose;
    public GameObject QuestItemToShow;

    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "You found the Battery, return to BB8.";
            StartCoroutine(CarryOn());
        }
    }

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(4);
        gameObject.SetActive(false);
        MessageBox.SetActive(false);
        QuestItemToClose.SetActive(false);
        QuestItemToShow.SetActive(true);
    }
}
	
