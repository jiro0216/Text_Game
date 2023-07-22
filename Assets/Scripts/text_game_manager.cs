using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class text_name_manager : MonoBehaviour
{
    public string choice1;
    public string story;
    public int hp_value;
    public TextMeshProUGUI HptextValue, storyTextValue,choice1Value;

    // Start is called before the first frame update
    void Start()
    {
        hp_value = 20;
        story = "woke up lost in the middle of the forest";
    }

    // Update is called once per frame
    void Update()
    {
        HptextValue.text = hp_value.ToString();
        storyTextValue.text = story;
        choice1Value.text = hp_value.ToString();
    }


    public void FirstChoice() {
        hp_value = -20;
        choice1Value.text = hp_value.ToString();

    }

    public void SecondChoice() {
        hp_value = -5;
       
    }

    public void ThirdChoice(){

        hp_value = +5;
       
    }

    public void FourthChoice()
    {
      
       
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
