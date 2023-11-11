using UnityEngine;
using System.Collections;

public class TrueClick : MonoBehaviour {

    public void onClick()
    {
        GamePlay.benar = true;
    }

    public void onClickFalse()
    {
        GamePlay.salah = true;
    }

}

