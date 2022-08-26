using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager instance;
    public Text currency;
    public Text lives;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Error: instance already created");
            return;
        }
        instance = this;
    }

    public float getCurrency()
    {
        return float.Parse(currency.text);
    }

    public void addMoney(float money)
    {
        currency.text = Mathf.Round(getCurrency() + money).ToString();
    }

    public void substractMoney(float money)
    {
        currency.text = Mathf.Round(getCurrency() - money).ToString();
    }

    public float getLives()
    {
        return float.Parse(lives.text);
    }

    public void substractLives(float damage)
    {
        lives.text = Mathf.Round(getLives() - damage).ToString();
        if (getLives() <= 0)
        {
            SceneManager.LoadSceneAsync("GameOver");
        }
    }
}
