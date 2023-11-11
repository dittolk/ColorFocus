using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int score;
    public static int inverted_score;
    private int oldHighScore;
    private int oldHighScore2;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (GamePlay.previous_scene == 1)
        {
            GameObject.Find("Mode").GetComponent<Text>().text = LanguangeLibrary.normal_mode; //mode text
            GameObject.Find("Score").GetComponent<Text>().text = LanguangeLibrary.score + score; //attach to text
            this.StoreHighscore(Score.score);
            GameObject.Find("High Score").GetComponent<Text>().text = LanguangeLibrary.live_high_score + this.oldHighScore;
        }
        else if(GamePlay.previous_scene == 2)
        {
            GameObject.Find("Mode").GetComponent<Text>().text = LanguangeLibrary.inverted_mode; //mode text
            GameObject.Find("Score").GetComponent<Text>().text = LanguangeLibrary.score + inverted_score; //attach to text
            this.StoreHighscore(Score.inverted_score);
            GameObject.Find("High Score").GetComponent<Text>().text = LanguangeLibrary.live_high_score + this.oldHighScore2;
        }
    }

    private void StoreHighscore(int newHighscore)
    {
        if (GamePlay.previous_scene == 1)
        {
            this.oldHighScore = PlayerPrefs.GetInt("highscore", 0);
            if (newHighscore > this.oldHighScore)
            {
                PlayerPrefs.SetInt("highscore", newHighscore);
                PlayerPrefs.Save();
            }
        }else if(GamePlay.previous_scene == 2)
        {
            this.oldHighScore2 = PlayerPrefs.GetInt("highscore2", 0);
            if (newHighscore > this.oldHighScore2)
            {
                PlayerPrefs.SetInt("highscore2", newHighscore);
                PlayerPrefs.Save();
            }
        }
    }
}
