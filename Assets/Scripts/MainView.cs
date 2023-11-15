using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] private GameObject _leaderboardUI;
    [SerializeField] private GameObject _inputNicknameUI;
    void Start()
    {
        _leaderboardUI.SetActive(false);
        _inputNicknameUI.SetActive(false);
    }
    public void GoInputNickname()
    {
        this.gameObject.SetActive(false);
        _inputNicknameUI.SetActive(true);
    }
    public void GoToLeaderboard()
    {
        this.gameObject.SetActive(false);
        _leaderboardUI.SetActive(true);
    }
}