using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Start : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
    }

    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox;
    public string TextMessage;
    public GameObject QuestBox;
    public GameObject QuestText;
    public string QuestName;
    public GameObject QuestItemToShow;

    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            QuestItemToShow.SetActive(true);
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = TextMessage;
            QuestName = "Active Quest: 'Recover The Battery'";
            QuestText.GetComponent<Text>().text = QuestName;
        }

        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
            TextMessage = "Please, I feel dizzy....";
        }
    }
    
        
    
}
	
	