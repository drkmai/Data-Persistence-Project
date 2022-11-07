using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private TMP_Text playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadHighscore();
    }

    public void StartGame()
    {
        GameManager.Instance.PlayerName = playerNameText.text;
        SceneManager.LoadScene(1);
    }

    public void HandleStartButtonInteraction(string str)
    {
        startButton.interactable = !string.IsNullOrEmpty(str);
    }
}
