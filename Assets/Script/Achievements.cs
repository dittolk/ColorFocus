using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour {
    
    //variable untuk menampung masing2 highscore
    private int best_score1;
    private int best_score2;

    void Update () {
        best_score1 = PlayerPrefs.GetInt("highscore");
        best_score2 = PlayerPrefs.GetInt("highscore2");

        if ((best_score1 == 0) || (best_score2 == 0))   //nothing
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Nothing";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Noob";
        }
        if ((best_score1 > 0) && (best_score2 > 0)) //noob
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Nothing";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Noob";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Normal";
        }
        if ((best_score1 >= 5) && (best_score2 >= 5))   //normal
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Noob";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Normal";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Cool";
        }
        if ((best_score1 >= 15) && (best_score2 >= 15)) //cool
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Normal";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Cool";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Super";
        }
        if ((best_score1 >= 25) && (best_score2 >= 25)) //super
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Cool";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Super";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Ultra";
        }
        if ((best_score1 >= 40) && (best_score2 >= 40)) //ultra
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Super";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Ultra";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Stephen\nHawking";
        }
        if ((best_score1 >= 60) && (best_score2 >= 60)) //stephen hawking
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Ultra";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Stephen\nHawking";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Isaac\nNewton";
        }
        if ((best_score1 >= 75) && (best_score2 >= 70)) //isaac newton
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Stephen\nHawking";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Isaac\nNewton";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "Albert\nEinstein";
        }
        if ((best_score1 >= 100) && (best_score2 >= 100)) //albert einstein
        {
            GameObject.Find("PreviousLevel").GetComponent<Text>().text = "Isaac\nNewton";
            GameObject.Find("LevelText").GetComponent<Text>().text = "Albert\nEinstein";
            GameObject.Find("NextLevel").GetComponent<Text>().text = "";
        }
    }
}
