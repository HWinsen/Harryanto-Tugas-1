using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int life;
    [SerializeField] private UIController _uIController;

    private void Start()
    {
        life = 3;
    }

    private void Update()
    {
        _uIController.lifeTMP.SetText("Life: " + life);
    }

    public void RemoveLife()
    {
        Debug.Log("trigger");

        
        life--;
        Debug.Log(life);
        _uIController.lifeIcon.RemoveAt(life);
        //_uIController.lifeIcon[2].SetActive(false);
    }
}
