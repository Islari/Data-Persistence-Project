using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public MainManager mainManager;

    public GameObject startButton;
    public GameObject exitButton;
    public Text bestScoreText;

    public int bestScore;
    public static string playerName;

    void Start()
    {
        bestScore = mainManager.m_Points;
        bestScoreText.text = "Best Score: " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void startGameButton()
    {
        SceneManager.LoadScene(1);
    }

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Exit()
    {
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
