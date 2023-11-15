using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreTMP;
    [SerializeField] private TextMeshProUGUI _nicknameTMP;

    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _ratingPanel;

    [SerializeField] private TextMeshProUGUI _leaderboardTMP;

    private void Start()
    {
        Time.timeScale = 1.0f;
        _pausePanel.SetActive(false);
        _ratingPanel.SetActive(false);

        GameManager.Score = 0;

    }
    private void Update()
    {
        _scoreTMP.text = GameManager.Score.ToString();
        _nicknameTMP.text = GameManager.Nickname.ToString();
    }
    public void Pause()
    {
        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0.0f;
            _pausePanel.SetActive(true);
        }
           
        else
        {
            Time.timeScale = 1.0f;
            _pausePanel.SetActive(false);
            _ratingPanel.SetActive(false);
        }
           
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");   
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ShowRating()
    {
        _leaderboardTMP.text = "";
        for (int i = 0; i < 10; i++)
        {
            if (PlayerPrefs.GetString($"Nickname_{i}") != "")
                _leaderboardTMP.text += $"{PlayerPrefs.GetString($"Nickname_{i}")} - {PlayerPrefs.GetInt($"Score_{i}")}\n";
        }
        if (_leaderboardTMP.text == "")
        {
            _leaderboardTMP.text = "≈щЄ никто не играл в эту игру.\n”спей стать первым!";
        }

        _ratingPanel.SetActive(true);
    }
}
