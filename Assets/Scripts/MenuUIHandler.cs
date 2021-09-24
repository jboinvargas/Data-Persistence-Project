using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public TMP_Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = $"Best Score : {DataMainManager.Instance.bestPlayerName} : {DataMainManager.Instance.bestScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        DataMainManager.Instance.playerName = playerNameInput.text;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        DataMainManager.Instance.SaveBestPlayer();
    }
}
