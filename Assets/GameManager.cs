using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public float GameDuration = 10f;
  
    public Text CurrentTimeText;
    public Text FinalScoreText;
    public GameObject[] TurnOnWhenEnd;
    public GameObject[] TurnOffWhenEnd;

    private ScoreManager _scoreManager;

    private float _timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        _timer = GameDuration;

       
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            if (CurrentTimeText)
                CurrentTimeText.text = _timer.ToString();
            return;
        }

        if (CurrentTimeText)
            CurrentTimeText.text = "0";

        for (int i = 0; i < TurnOnWhenEnd.Length; i++)
        {
            TurnOnWhenEnd[i].SetActive(true);
        }

        for(int i = 0; i < TurnOffWhenEnd.Length; i++)
        {
            TurnOffWhenEnd[i].SetActive(false);
        }

        if( _scoreManager && CurrentTimeText)
        {
            FinalScoreText.text = _scoreManager.CurrentScore.ToString();
        }



        
    }
}
