using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static float timeNum;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI diamondText;

    private string result;
    public GameObject resultShow;
    public GameObject playerCamera;
    public GameObject player;
    public GameObject bg;

    public GameObject[] diamonds;
    const int STARTNUM=0;
    const int ENDNUM=31;
    const int NUMNUM=5;

    public static bool casual = false;
    public GameObject timerUI;
    public TextMeshProUGUI diamondBasText;

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGameStat();
        ShowDiamondNum();
        PlayerBackToMenuCheck();
    }

    void CheckGameStat()
    {
        if (!casual)
        {
            SkillfullCheckGameStat();
        }
        else
        {
            CasualCheckGameStat();
        }
    }

    void CasualCheckGameStat()
    {
        if (GemTotal.gemNum == 32)
        {
            resultShow.SetActive(true);
            bg.SetActive(true);
            playerCamera.transform.parent = null;
            player.SetActive(false);
            result = "Congrats! You have found all " + GemTotal.gemNum + " diamonds!!!";
            resultText.text = result.ToString();
        }
    }

    void SkillfullCheckGameStat()
    {
        if (timeNum > 1 && GemTotal.gemNum <5)
        { Timer(); }
        else if (GemTotal.gemNum == 5 )
        {
            resultShow.SetActive(true);
            bg.SetActive(true);
            playerCamera.transform.parent = null;
            player.SetActive(false);
            result = "HOLY MOLLY!! You've got " + GemTotal.gemNum + " diamonds!!!";
            resultText.text = result.ToString();
        }
        else if (GemTotal.gemNum ==4)
        {
            resultShow.SetActive(true);
            bg.SetActive(true);
            playerCamera.transform.parent = null;
            player.SetActive(false);
            result = "OH MY GOD!! You've got " + GemTotal.gemNum + " diamonds!!!";
            resultText.text = result.ToString();
        }
        else if (GemTotal.gemNum ==3)
        {
            resultShow.SetActive(true);
            bg.SetActive(true);
            playerCamera.transform.parent = null;
            player.SetActive(false);
            result = "OH YAY!! You've got " + GemTotal.gemNum + " diamonds!!!";
            resultText.text = result.ToString();
        }
        else if (GemTotal.gemNum ==2)
        {
            resultShow.SetActive(true);
            bg.SetActive(true);
            playerCamera.transform.parent = null;
            player.SetActive(false);
            result = "NOT BAD!! You've got " + GemTotal.gemNum + " diamonds!!!";
            resultText.text = result.ToString();
        }
        else
        {
            resultShow.SetActive(true);
            bg.SetActive(true);
            playerCamera.transform.parent = null;
            player.SetActive(false);
            result = "Come on!! You've got ONLY " + GemTotal.gemNum + " diamonds!?";
            resultText.text = result.ToString();
        }
    }
    void Timer()
    {
        timeNum = timeNum - Time.deltaTime;
        int timeInt = (int)timeNum;
        timeText.text = timeInt.ToString() + "s";
    }

    void ShowDiamondNum()
    {
        diamondText.text = GemTotal.gemNum.ToString();
    }

    void RandomlySelectDiamonds()
    {
        int[] temps = new int[NUMNUM];
        for (int i = 0; i < NUMNUM; i++)
        {
            int temp = Random.Range(STARTNUM, ENDNUM);
            bool keepCheck = true;
            bool repeat = false;
            while (keepCheck)
            {
                repeat = false;
                foreach (int x in temps)
                {
                    if (x.Equals(temp))
                    {
                        repeat = true;
                    }
                }
                if (!repeat) //if it's not exist, stop checking
                {
                    keepCheck = false;
                }
                else
                {
                    temp = Random.Range(STARTNUM, ENDNUM+1); //if repeat, change temp value
                }
            }

            temps[i] = temp; //add the temp number into array temps
            //Debug.Log(temps[i]);
            diamonds[temp].SetActive(true); //set the index of diamonds array active
        }

        

    }

    void PlayerBackToMenuCheck()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            SceneManager.LoadScene("StartScene");
        }

    }


    void ResetGame()
    {
        GemTotal.gemNum = 0;

        resultShow.SetActive(false);
        bg.SetActive(false);
        player.SetActive(true);
        playerCamera.transform.SetParent(player.transform);


        if (!casual)
        {
            timerUI.SetActive(true);
            RandomlySelectDiamonds();
            diamondBasText.text = "/ " + NUMNUM.ToString();
            timeNum = 220;
        }
        else
        {
            timerUI.SetActive(false);
            diamondBasText.text = "/32";
            for (int i = 0; i < 32; i++)
            {
                diamonds[i].SetActive(true);
            }

        }

    }
}
