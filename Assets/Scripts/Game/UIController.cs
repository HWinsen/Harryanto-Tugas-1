using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Game
{
    public class UIController : MonoBehaviour
    {
        public GameObject losePanel;
        public GameObject[] lifeIcon;

        public void SetLosePanelActive()
        {
            losePanel.SetActive(true);
        }

        public void SetLifeInactive(int index)
        {
            lifeIcon[index].SetActive(false);
        }
    }
}