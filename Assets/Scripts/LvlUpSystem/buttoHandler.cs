using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttoHandler : MonoBehaviour
{
    public GameObject panel;
    public GameObject playerStats;

    public float passiveHeal;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed = playerStats.GetComponent<playerStats>().speed * 0.05f;
        passiveHeal = playerStats.GetComponent<playerStats>().maxHP * 0.01f;
    }


    public void increaseAttack()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        playerStats.GetComponent<playerStats>().upgradeAttack(5, true);
    }

    public void increaseHealth()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        playerStats.GetComponent<playerStats>().upgradeHealth(20, true);
    }

    public void PassiveHeal()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        playerStats.GetComponent<playerStats>().upgradeHeal(passiveHeal, true);
    }

    public void increaseMovementSpeed()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        playerStats.GetComponent<playerStats>().upgradeSpeed(speed, true);
    }
}
