using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Game : MonoBehaviour
{
    [SerializeField] int Score;

    public GameObject InternetPanel;
    public GameObject ClikerPanel;
    public GameObject HackPanel;
    public GameObject ThingPanel1;
    public GameObject ThingPanel2;
    public GameObject ResultPanel;

    public Text ScoreText;
    public void OnClickButton()
    {
        Score++;
    }

    private void Update()
    {
        ScoreText.text = Score + "₽";
    }

    public void ShowAndHideInternetPanel()
    {
        InternetPanel.SetActive(!InternetPanel.activeSelf);
    }
    public void ShowAndHideClikerPanel()
    {
        ClikerPanel.SetActive(!ClikerPanel.activeSelf);
    }
    public void ShowAndHideHackPanel()
    {
        HackPanel.SetActive(!HackPanel.activeSelf);
    }
    public void ShowAndHideThingPanel1()
    {
        ThingPanel1.SetActive(!ThingPanel1.activeSelf);
    }
    public void ShowAndHideThingPanel2()
    {
        ThingPanel2.SetActive(!ThingPanel2.activeSelf);
    }
    public void ShowAndHideResultPanel()
    {
        ResultPanel.SetActive(!ResultPanel.activeSelf);
    }

    //public void EnterText()
    //{

    //}
}
