using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{

    public static float countdown;
    
    // Use this for initialization
    void Start()
    {
        countdown = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown > 3)
        {
            countdown = 3;
        }

        countdown -= Time.deltaTime; //every 1 second
        GetComponent<Text>().text = string.Empty + countdown; //attach to text
        if (countdown < 0.1f)
        {
            SceneManager.LoadScene("GameOver"); //open scene game over
        }
    }

}
