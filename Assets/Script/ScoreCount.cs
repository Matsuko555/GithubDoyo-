using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private float score;
    private GameObject data;
    private Data dataCs;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data> ();
    }

    // Update is called once per frame
    void Update()
    {
        score = dataCs.score;
        scoreText.text = "Score" + score.ToString();
    }
}
