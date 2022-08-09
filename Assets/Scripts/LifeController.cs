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

    public void RemoveLife()
    {
        Debug.Log("trigger");

        //_uIController.lifeIcon[life].SetActive(false);
        life--;
        Debug.Log(life);
        //_uIController.lifeIcon[2].SetActive(false);
    }
}
