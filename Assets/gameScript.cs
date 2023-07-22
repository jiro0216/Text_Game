using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    private int health; 
    public GameObject UI,titleScreen, level1, level2, level3, level4, level5, endingLost,endingWon;
    public TextMeshProUGUI healthText;
    // Start is called before the first frame update
    void Start()
    {
        titleScreen.SetActive(true);
        health = 50;
       
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        Dead();
    }

    public void Dead() {

        if (health <= 0)
        {

            level1.SetActive(false);
            level2.SetActive(false);
            level3.SetActive(false);
            level4.SetActive(false);
            level5.SetActive(false);
            endingLost.SetActive(true);

        }
    }

    public void StartGameButton()
    {
        titleScreen.SetActive(false);
        endingLost.SetActive(false);
        level1.SetActive(true);
        health = 50;

    }      

    public void Button_a1()
    {
        level1.SetActive(false);
        endingLost.SetActive(true);
       

    }
    public void Button_b2()
    {
        health -= 10;

    }
    public void Button_c3()
    { 
        level1.SetActive(false);
        level2.SetActive(true);


    }
    public void Button_d4()
    {
        level1.SetActive(false);
        level3.SetActive(true);
        health += 5;

    }

    //level 2 buttons
    public void Button_a5()
    {
        level2.SetActive(false);
        endingLost.SetActive(true);


    }
    public void Button_b6()
    {
        health -= 25;

    }
    public void Button_c7()
    {
        level2.SetActive(false);
        level4.SetActive(true);


    }
    public void Button_d8()
    {
  
        health += 5;

    }
    //level 3 buttons
    public void Button_a9()
    {
        level3.SetActive(false);
        endingLost.SetActive(true);


    }
    public void Button_b10()
    {
        health -= 15;

    }
    public void Button_c11()
    {
        level3.SetActive(false);
        level5.SetActive(true);


    }
    public void Button_d12()
    {

        health += 5;

    }
    
    //level 4 buttons
    public void Button_a13()
    {
        level4.SetActive(false);
        endingLost.SetActive(true);


    }
    public void Button_b14()
    {
        health -= 15;

    }
    public void Button_c15()
    {
        level4.SetActive(false);
        endingLost.SetActive(true);


    }
    public void Button_d16()
    {
        level4.SetActive(false);
        endingLost.SetActive(true);

    }

    //level 4 buttons
    public void Button_a17()
    {
        level5.SetActive(false);
        endingLost.SetActive(true);


    }
    public void Button_b18()
    {
        health -= 5;

    }
    public void Button_c19()
    {
        level5.SetActive(false);
        endingWon.SetActive(true);


    }
    public void Button_d20()
    {
        level4.SetActive(false);
        endingLost.SetActive(true);

    }



    //button to exit a the program
    public void QuitApplication()
     {
       
          Application.Quit();
  
     }





}
