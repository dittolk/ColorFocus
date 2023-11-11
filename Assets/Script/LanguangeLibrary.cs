using UnityEngine;
using UnityEngine.UI;

public class LanguangeLibrary : MonoBehaviour {

    public static LanguangeLibrary Instance { set; get; }
    public static int status_bahasa;

    /*for the menu*/
    public static string play;
    public static string high_score;
    public static string live_high_score;
    public static string score;
    public static string exit;
    public static string back;
    public static string share;
    public static string about;
    public static string play_again;
    public static string menu;
    public static string game_over;
    public static string rate_us;
    public static string like_us;
    public static string how_to_play;
    public static string description;
    public static string title_menu;
    public static string select_mode, normal_mode, inverted_mode;

    /*for the gameplay*/
    public static string red_text;
    public static string blue_text;
    public static string cyan_text;
    public static string orange_text;
    public static string green_text;
    public static string black_text;
    public static string brown_text;
    public static string yellow_text;
    public static string magenta_text;
    public static string purple_text;
    

    // Use this for initialization
    void Start () {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {

        /* BUTTON TEXT */
        if (GameObject.Find("PlayText") != null)
        {
            GameObject.Find("PlayText").GetComponent<Text>().text = play;
        }

        if (GameObject.Find("ScoreText") != null)
        {
            GameObject.Find("ScoreText").GetComponent<Text>().text = high_score;
            if (status_bahasa == 1 || status_bahasa == 3)
            {
                GameObject.Find("ScoreText").GetComponent<Text>().fontSize = 60;
            }
        }
        if (GameObject.Find("ExitText") != null)
        {
            GameObject.Find("ExitText").GetComponent<Text>().text = exit;
        }
        if (GameObject.Find("BackText") != null)
        {
            GameObject.Find("BackText").GetComponent<Text>().text = back;
        }
        if (GameObject.Find("AboutText") != null)
        {
            GameObject.Find("AboutText").GetComponent<Text>().text = about;
        }
        if (GameObject.Find("ShareText") != null)
        {
            GameObject.Find("ShareText").GetComponent<Text>().text = share;
        }
        if (GameObject.Find("PlayAgainText") != null)
        {
            GameObject.Find("PlayAgainText").GetComponent<Text>().text = play_again;
        }
        if (GameObject.Find("MenuText") != null)
        {
            GameObject.Find("MenuText").GetComponent<Text>().text = menu;
        }
        if (GameObject.Find("RateUsText") != null)
        {
            GameObject.Find("RateUsText").GetComponent<Text>().text = rate_us;
            if(status_bahasa == 1)
            {
                GameObject.Find("RateUsText").GetComponent<Text>().fontSize = 65;
            }
        }
        if (GameObject.Find("LikeUsText") != null)
        {
            GameObject.Find("LikeUsText").GetComponent<Text>().text = like_us;
        }
        


        /* UI TEXT */
        if (GameObject.Find("GameOverText") != null)
        {
            GameObject.Find("GameOverText").GetComponent<Text>().text = game_over;
        }
        if (GameObject.Find("TitleMenu") != null)
        {
            GameObject.Find("TitleMenu").GetComponent<Text>().text = title_menu;
        }
        if (GameObject.Find("Description") != null)
        {
            GameObject.Find("Description").GetComponent<Text>().text = description;
            if (status_bahasa == 2 || status_bahasa == 3)
            {
                GameObject.Find("Description").GetComponent<Text>().fontSize = 35;
            }
        }
        if(GameObject.Find("NormalText") != null && GameObject.Find("InvertedText") != null && GameObject.Find("SelectMode") != null)
        {
            GameObject.Find("NormalText").GetComponent<Text>().text = normal_mode;
            GameObject.Find("InvertedText").GetComponent<Text>().text = inverted_mode;
            GameObject.Find("SelectMode").GetComponent<Text>().text = select_mode;
        }
        if (GameObject.Find("How To Play") != null)
        {
            GameObject.Find("How To Play").GetComponent<Text>().text = how_to_play;
        }
        if (GameObject.Find("Blue Text") != null)
        {
            GameObject.Find("Blue Text").GetComponent<Text>().text = blue_text.ToLower();
        }
        if (GameObject.Find("Red Text") != null)
        {
            GameObject.Find("Red Text").GetComponent<Text>().text = red_text.ToLower();
        }
        if (GameObject.Find("Magenta Text") != null)
        {
            GameObject.Find("Magenta Text").GetComponent<Text>().text = magenta_text.ToLower();
        }
        if (GameObject.Find("Brown Text") != null)
        {
            GameObject.Find("Brown Text").GetComponent<Text>().text = brown_text.ToLower();
        }
        if (GameObject.Find("Purple Text") != null)
        {
            GameObject.Find("Purple Text").GetComponent<Text>().text = purple_text.ToLower();
        }
        if (GameObject.Find("Cyan Text") != null)
        {
            GameObject.Find("Cyan Text").GetComponent<Text>().text = cyan_text.ToLower();
        }
        if (GameObject.Find("Black Text") != null)
        {
            GameObject.Find("Black Text").GetComponent<Text>().text = black_text.ToLower();
        }
        if (GameObject.Find("Green Text") != null)
        {
            GameObject.Find("Green Text").GetComponent<Text>().text = green_text.ToLower();
        }
        if (GameObject.Find("Orange Text") != null)
        {
            GameObject.Find("Orange Text").GetComponent<Text>().text = orange_text.ToLower();
        }
        if (GameObject.Find("Yellow Text") != null)
        {
            GameObject.Find("Yellow Text").GetComponent<Text>().text = yellow_text.ToLower();
        }
    }

}
