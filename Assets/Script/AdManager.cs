using UnityEngine;
using admob;

public class AdManager : MonoBehaviour {

    public static AdManager Instance { set; get; }
	// Use this for initialization
	void Start () {
        Instance = this;
        //DontDestroyOnLoad(gameObject);

        #if UNITY_EDITOR
        #elif UNITY_ANDROID
            Admob.Instance().initAdmob("-", "ca-app-pub-2059511214389898/8110130768");
            //Admob.Instance().setTesting(true);
            Admob.Instance().loadInterstitial();
        #endif
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowInterstitial()
    {
        #if UNITY_EDITOR
        Debug.Log("Can't play ads from unity editor");
        #elif UNITY_ANDROID
        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
        }
        #endif
    }
}
