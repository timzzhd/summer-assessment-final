using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour
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
        if (coinAmount >= 3)
            SceneManager.LoadScene("Level 2");

    }

}
