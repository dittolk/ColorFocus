using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadOnClick : MonoBehaviour
{
    int tmp_menu;
    // Store more screenshots...
    private int Screen_Shot_Count = 0;
    // Screenshot taking by touch the button.
    public GUITexture Capture_Model;
    // Check the Shot Taken/Not.
     private bool Shot_Taken = false;
    // Name of the File.
    private string Screen_Shot_File_Name;


    // public
    // private
    public string message = "Download Color Focus now!";

    //for game over scene
    int play_again;

    IEnumerator ChangeLevel()
    {
        //fade out screen
        float fadeTime = GameObject.Find("Fade").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(tmp_menu);
    }

    IEnumerator ShareToInstalledApps(string path)
    {
        yield return new WaitForSeconds(3);

        //instantiate the class Intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");

        //instantiate the object Intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");

        //call setAction setting ACTION_SEND as parameter
        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));

        //instantiate the class Uri
        AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
        //instantiate the object Uri with the parse of the url's file
        AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + path);

        //call putExtra with the uri object of the file
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);

        //set the type of file
        intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");

        //instantiate the class UnityPlayer
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

        //instantiate the object currentActivity
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //call the activity with our Intent
        currentActivity.Call("startActivity", intentObject);
    }

    public IEnumerator ShareScreenshot()
    {
        // wait for graphics to render
        yield return new WaitForEndOfFrame();
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- PHOTO
        // create the texture
        Texture2D screenTexture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, true);
        // put buffer into texture
        screenTexture.ReadPixels(new Rect(0f, 0f, Screen.width, Screen.height), 0, 0);
        // apply
        screenTexture.Apply();
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- PHOTO
        byte[] dataToSave = screenTexture.EncodeToPNG();
        string destination = System.IO.Path.Combine(Application.persistentDataPath, System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".png");
        System.IO.File.WriteAllBytes(destination, dataToSave);
        if (!Application.isEditor)
        {
            // block to open the file and share it ------------START
            AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
            AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
            AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + destination);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);

            intentObject.Call<AndroidJavaObject>("setType", "text/plain");
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), "" + message);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), "Beat my high Score!");

            intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

            currentActivity.Call("startActivity", intentObject);
        }
    }

    public void MainMenu(int menu)
	{
        tmp_menu = menu;
        StartCoroutine(ChangeLevel());
	}

    public void PlayAgain()
    {
        if(GamePlay.previous_scene == 1)
        {
            play_again = 2;
        }else if(GamePlay.previous_scene == 2)
        {
            play_again = 7;
        }
        SceneManager.LoadScene(play_again);
    }

    public void ChangeScene(int change)
    {
        SceneManager.LoadScene(change);
    }
	
	public void end()
	{
        Application.Quit();
	}
	
	public void link()
	{
		Application.OpenURL("http://www.facebook.com/trois.studio");
	}

    public void Rate()
    {
        Application.OpenURL("market://details?id=com.TroisStudio.ColorFocus");
    }

    /*public void screenshot()
    {
        // Increament the screenshot count
        Screen_Shot_Count += 1;
        // Save the screenshot name as Screenshot_1.png, Screenshot_2.png, with date format...
        Screen_Shot_File_Name = "Screenshot__" + Screen_Shot_Count + System.DateTime.Now.ToString("__yyyy-MM-dd") + ".png";

        Application.CaptureScreenshot(Screen_Shot_File_Name);
        Shot_Taken = true;

        if (Shot_Taken == true)
        {
            string Origin_Path = System.IO.Path.Combine(Application.persistentDataPath, Screen_Shot_File_Name);
            // This is the path of my folder.
            string Path = "/mnt/sdcard/ColorFocus/Screenshots/" + Screen_Shot_File_Name;
            string location = "/mnt/sdcard/ColorFocus/Screenshots/";

            if (System.IO.Directory.Exists(location) == false)
            {
                System.IO.Directory.CreateDirectory(location);
            }

            if (System.IO.File.Exists(Origin_Path))
            {
                System.IO.File.Move(Origin_Path, location);
                Shot_Taken = false;
            }

            print(Path);
            StartCoroutine(ShareToInstalledApps(Path));
        }

    }*/

    public void screenshot()
    {
        StartCoroutine(ShareScreenshot());
    }
}