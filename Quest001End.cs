using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001End : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox;
    public GameObject QuestBox;
    public GameObject QuestText;
 

    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
        
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "Thank You! Come back later for more...";
            QuestText.GetComponent<Text>().text = "Active Quest: None";
        }

        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
            //TextMessage = "Please, I am low on battery!";
        }
    }



}

