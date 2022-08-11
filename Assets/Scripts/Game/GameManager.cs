using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LifeController _lifeController;
    [SerializeField] private UIController _uIController;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // if life controller darah < 3, maka lose
        if (_lifeController.life <= 0)
        {
            Lose();
        }
    }

    public void Lose()
    {
        _lifeController.life = 0;
        _uIController.losePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        Debug.Log(Time.timeScale);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
