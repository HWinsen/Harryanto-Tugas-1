using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Agate.TapZombie.Game
{
    public class UIController : MonoBehaviour
    {
        public GameObject losePanel;
        public GameObject life1;
        public GameObject life2;
        public GameObject life3;

        public void SetLosePanelActive()
        {
            losePanel.SetActive(true);
        }

        public void SetLife3Inactive()
        {
            life3.SetActive(false);
        }

        public void SetLife2Inactive()
        {
            life2.SetActive(false);
        }

        public void SetLife1Inactive()
        {
            life1.SetActive(false);
        }
    }
}