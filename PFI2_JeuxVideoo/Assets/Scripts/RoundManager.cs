using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{

    float timeBetweenRound = 5;
    float timeForRound = 60;

    float basicEnemmiByRound = 10;
    float moreEnemmyByRound = 5;
    [SerializeField] GameObject basicEnemmi;
    [SerializeField] TextMeshProUGUI textCountdown;
    [SerializeField] GameObject[] SpawnPoints;

    float time = 0;
    int numberOfRounds = 1;
    bool roundIsStarted = false;
    bool finishedSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownBetweenRound());
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 15)
        {
            if(!roundIsStarted)
            {
                return;
            }
            if(!finishedSpawning)
            {
                return;
            }
            if (GameObject.Find("Enemmi(Clone)") == null)
            {
                RoundIsFinished();
            }
            
        }
    }

    void StartRound()
    {
        roundIsStarted = true;
        StartCoroutine(SpawnEnnemies());

    }


    IEnumerator SpawnEnnemies()
    {
        finishedSpawning= false;
        float time = 0;
        float tick = timeForRound / basicEnemmiByRound;
        int random;
        while(timeForRound>time)
        {
            random =Random.Range(0, SpawnPoints.Length);
            Instantiate(basicEnemmi, SpawnPoints[random].transform.position, SpawnPoints[random].transform.rotation);

            time+= tick;
            yield return new WaitForSeconds(tick);
        }
        finishedSpawning= true;
        
    }

    public void RoundIsFinished()
    {
        basicEnemmiByRound = basicEnemmiByRound + moreEnemmyByRound;
        roundIsStarted= false;
        StartCoroutine(CountdownBetweenRound());
    }

    IEnumerator CountdownBetweenRound()
    {
        int time = 0;
        while(timeBetweenRound >= time)
        {

            textCountdown.text = (timeBetweenRound-time).ToString();
            if(time == timeBetweenRound)
            {
                textCountdown.text = "Manche " +numberOfRounds;
                yield return new WaitForSeconds(2);
            }
            time++;
            yield return new WaitForSeconds(1);
        }
        textCountdown.text = "";
        numberOfRounds++; 
        StartRound();
    }
}
