using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour {

    /*DEKLARASI VARIABEL*/
    int hasil_random;
    public static bool benar = false; //digunakan untuk tombol true
    public static bool salah = false; //digunakan untuk tombol false
    public AudioSource correct_sound;
    

    /*DEKLARASI WARNA*/
    Color purple = new Color(0.59f, 0.22f, 0.91f, 1.0f);
    Color orange = new Color(1.0f, 0.6f, 0.0f, 1.0f);
    Color brown = new Color(0.59f, 0.33f, 0.25f, 1.0f);

    public int warna_random;
    public int text_random;
    public int status_warna;
    public string str_warna = "";
    public string str_warna2 = "";
    int temp_score;
    public static int previous_scene;

    // Use this for initialization
    void Start () {
        correct_sound = GameObject.Find("CorrectSound").GetComponent<AudioSource>();
        Score.score = 0;
        Score.inverted_score = 0;
        previous_scene = 0;
        proses_warna(); //prosedur random warna
        proses_text_warna(); //prosedur random text warna
    }
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "GamePlay") //MODE NORMAL
        {
            previous_scene = 1;
            if (benar == true) //jika tombol true ditekan
            {
                if (str_warna == str_warna2) //validasi warna
                {
                    CountDown.countdown += 0.7f; //countdown direset
                    temp_score += 1; //score bertambah
                    Score.score = temp_score;

                    correct_sound.Play(); //play sound correct

                    proses_warna(); //proses random warna
                    proses_text_warna(); //proses random text warna
                    benar = false;
                }
                else
                {
                    benar = false;
                    SceneManager.LoadScene("GameOver"); //load scene GameOver
                }
            }
            else if (salah == true) //jika tombol false ditekan
            {
                if (str_warna != str_warna2) //validasi warna
                {
                    CountDown.countdown += 0.7f; //countdown direset
                    temp_score += 1; //score bertambah
                    Score.score = temp_score;

                    correct_sound.Play(); //play sound correct

                    proses_warna(); //proses random warna
                    proses_text_warna(); //proses random text warna
                    salah = false;
                }
                else
                {
                    salah = false;
                    SceneManager.LoadScene("GameOver"); //load scene GameOver
                }
            }
        }else if(SceneManager.GetActiveScene().name == "Gameplay2") //MODE INVERTED
        {
            previous_scene = 2;
            if (benar == true) //jika tombol true ditekan
            {
                if (str_warna != str_warna2) //validasi warna
                {
                    CountDown.countdown += 0.7f; //countdown direset
                    temp_score += 1; //score bertambah
                    Score.inverted_score = temp_score;

                    correct_sound.Play(); //play sound correct

                    proses_warna(); //proses random warna
                    proses_text_warna(); //proses random text warna
                    benar = false;
                }
                else
                {
                    benar = false;
                    SceneManager.LoadScene("GameOver"); //load scene GameOver
                }
            }
            else if (salah == true) //jika tombol false ditekan
            {
                if (str_warna == str_warna2) //validasi warna
                {
                    CountDown.countdown += 0.7f; //countdown direset
                    temp_score += 1; //score bertambah
                    Score.inverted_score = temp_score;

                    correct_sound.Play(); //play sound correct

                    proses_warna(); //proses random warna
                    proses_text_warna(); //proses random text warna
                    salah = false;
                }
                else
                {
                    salah = false;
                    SceneManager.LoadScene("GameOver"); //load scene GameOver
                }
            }
        }
    }

    //------------------------------------------------------------
    //                       MAIN PROCESS
    //------------------------------------------------------------

    void proses_warna()
    {
        warna_random = Random.Range(0, 10);

        if (warna_random == 0)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.blue;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.blue;
            str_warna = LanguangeLibrary.blue_text;
            status_warna = 0;
        }
        else if (warna_random == 1)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.red;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.red;
            str_warna = LanguangeLibrary.red_text;
            status_warna = 1;
        }
        else if (warna_random == 2)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.yellow;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.yellow;
            str_warna = LanguangeLibrary.yellow_text;
            status_warna = 2;
        }
        else if (warna_random == 3)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.green;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.green;
            str_warna = LanguangeLibrary.green_text;
            status_warna = 3;
        }
        else if (warna_random == 4)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.black;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.black;
            str_warna = LanguangeLibrary.black_text;
            status_warna = 4;
        }
        else if (warna_random == 5)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.magenta;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.magenta;
            str_warna = LanguangeLibrary.magenta_text;
            status_warna = 5;
        }
        else if (warna_random == 6)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.cyan;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.cyan;
            str_warna = LanguangeLibrary.cyan_text;
            status_warna = 6;
        }
        else if (warna_random == 7)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = purple;
            GameObject.Find("Warna2").GetComponent<Image>().color = purple;
            str_warna = LanguangeLibrary.purple_text;
            status_warna = 7;
        }
        else if (warna_random == 8)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = orange;
            GameObject.Find("Warna2").GetComponent<Image>().color = orange;
            str_warna = LanguangeLibrary.orange_text;
            status_warna = 8;
        }
        else if (warna_random == 9)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = brown;
            GameObject.Find("Warna2").GetComponent<Image>().color = brown;
            str_warna = LanguangeLibrary.brown_text;
            status_warna = 9;
        }
        else if (warna_random == 10)
        {
            GameObject.Find("Warna").GetComponent<Image>().color = Color.grey;
            GameObject.Find("Warna2").GetComponent<Image>().color = Color.grey;
            str_warna = "GREY";
            status_warna = 10;
        }
    }

    void proses_text_warna()
    {
        text_random = Random.Range(0, 10);
        hasil_random = Random.Range(0, 100);

        if (hasil_random % 2 == 1)
        {
            if (text_random == 0)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.cyan_text;
                str_warna2 = LanguangeLibrary.cyan_text;
                proses_text_warna_sub();
            }
            else if (text_random == 1)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.magenta_text;
                str_warna2 = LanguangeLibrary.magenta_text;
                proses_text_warna_sub();

            }
            else if (text_random == 2)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.black_text;
                str_warna2 = LanguangeLibrary.black_text;
                proses_text_warna_sub();

            }
            else if (text_random == 3)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.green_text;
                str_warna2 = LanguangeLibrary.green_text;
                proses_text_warna_sub();

            }
            else if (text_random == 4)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.yellow_text;
                str_warna2 = LanguangeLibrary.yellow_text;
                proses_text_warna_sub();

            }
            else if (text_random == 5)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.red_text;
                str_warna2 = LanguangeLibrary.red_text;
                proses_text_warna_sub();

            }
            else if (text_random == 6)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.blue_text;
                str_warna2 = LanguangeLibrary.blue_text;
                proses_text_warna_sub();

            }
            else if (text_random == 7)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.brown_text;
                str_warna2 = LanguangeLibrary.brown_text;
                proses_text_warna_sub();
            }
            else if (text_random == 8)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.purple_text;
                str_warna2 = LanguangeLibrary.purple_text;
                proses_text_warna_sub();
            }
            else if (text_random == 9)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.orange_text;
                str_warna2 = LanguangeLibrary.orange_text;
                proses_text_warna_sub();
            }
            else if (text_random == 10)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = "GREY";
                str_warna2 = "GREY";
                proses_text_warna_sub();
            }
        }
        else if (hasil_random % 2 == 0)
        {
            if (status_warna == 0)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.blue_text;
                str_warna2 = LanguangeLibrary.blue_text;
                proses_text_warna_sub();
            }
            else if (status_warna == 1)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.red_text;
                str_warna2 = LanguangeLibrary.red_text;
                proses_text_warna_sub();

            }
            else if (status_warna == 2)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.yellow_text;
                str_warna2 = LanguangeLibrary.yellow_text;
                proses_text_warna_sub();

            }
            else if (status_warna == 3)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.green_text;
                str_warna2 = LanguangeLibrary.green_text;
                proses_text_warna_sub();

            }
            else if (status_warna == 4)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.black_text;
                str_warna2 = LanguangeLibrary.black_text;
                proses_text_warna_sub();

            }
            else if (status_warna == 5)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.magenta_text;
                str_warna2 = LanguangeLibrary.magenta_text;
                proses_text_warna_sub();

            }
            else if (status_warna == 6)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.cyan_text;
                str_warna2 = LanguangeLibrary.cyan_text;
                proses_text_warna_sub();
            }
            else if (status_warna == 7)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.purple_text;
                str_warna2 = LanguangeLibrary.purple_text;
                proses_text_warna_sub();
            }
            else if (status_warna == 8)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.orange_text;
                str_warna2 = LanguangeLibrary.orange_text;
                proses_text_warna_sub();
            }
            else if (status_warna == 9)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = LanguangeLibrary.brown_text;
                str_warna2 = LanguangeLibrary.brown_text;
                proses_text_warna_sub();
            }
            else if (status_warna == 10)
            {
                GameObject.Find("TextWarna").GetComponent<Text>().text = "GREY";
                str_warna2 = "GREY";
                proses_text_warna_sub();
            }
        }
    }

    void proses_text_warna_sub()
    {
        //-----------------------WARNA TEXT-------------------------
        if (warna_random == 0)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.blue;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.blue;
        }
        else if (warna_random == 1)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.red;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.red;
        }
        else if (warna_random == 2)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.yellow;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.yellow;
        }
        else if (warna_random == 3)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.green;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.green;
        }
        else if (warna_random == 4)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.black;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.black;
        }
        else if (warna_random == 5)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.magenta;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.magenta;
        }
        else if (warna_random == 6)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.cyan;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.cyan;
        }
        else if (warna_random == 7)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = purple;
            GameObject.Find("CountDown").GetComponent<Text>().color = purple;
        }
        else if (warna_random == 8)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = orange;
            GameObject.Find("CountDown").GetComponent<Text>().color = orange;
        }
        else if (warna_random == 9)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = brown;
            GameObject.Find("CountDown").GetComponent<Text>().color = brown;
        }
        else if (warna_random == 10)
        {
            GameObject.Find("TextWarna").GetComponent<Text>().color = Color.grey;
            GameObject.Find("CountDown").GetComponent<Text>().color = Color.grey;
        }
        //----------------------------------------------
    }


}
