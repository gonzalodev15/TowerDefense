using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Base : MonoBehaviour
{
    public static int baseLife = 5;

    public static void substractBaseLife(int enemyAttack)
    {
        baseLife -= enemyAttack;
        if (baseLife <= 0)
        {
            SceneManager.LoadSceneAsync("GameOver");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            int enemyDamage = collision.gameObject.GetComponent<Enemy>().enemyDamage;
            substractBaseLife(enemyDamage);
        }
    }
}
