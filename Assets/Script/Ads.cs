using UnityEngine;
using System.Collections;

public class Ads : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
        //RequestInterstitial();
        StartCoroutine(ShowAds());
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    IEnumerator ShowAds()
    {
        yield return new WaitForSeconds(0.2f);
        AdManager.Instance.ShowInterstitial();
    }

    /*public void RequestInterstitial()
    {
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-2059511214389898/8110130768";
        #elif UNITY_IPHONE
                                string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
        #else
                                string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        InterstitialAd interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }*/


}
