using TMPro;
using UnityEngine;

public class LeaderboardView : MonoBehaviour
{
    [SerializeField] private GameObject _mainUI;

    [SerializeField] private TextMeshProUGUI _leaderboardTmp;
    void Start()
    {
        _leaderboardTmp.text = "";
        for (int i = 0; i < 10; i++)
        {
            if (PlayerPrefs.GetString($"Nickname_{i}") != "")
                _leaderboardTmp.text += $"{PlayerPrefs.GetString($"Nickname_{i}")} - {PlayerPrefs.GetInt($"Score_{i}")}\n";
        }
        if (_leaderboardTmp.text == "")
        {
            _leaderboardTmp.text = "≈щЄ никто не играл в эту игру.\n”спей стать первым!";
        }
    }
    public void GoToMainMenu()
    {
        _mainUI.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
