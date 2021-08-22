using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextScriptLevel2 : MonoBehaviour
{
    public Text text;
    public static int coinAmount;

    void start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = coinAmount.ToString();
        if (coinAmount >= 4)
            SceneManager.LoadScene("Winner");

    }
}
