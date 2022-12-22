using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RespawnCharacter : MonoBehaviour
{
    public GameObject[] healthImg;
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.Sethealth(maxHealth);
    }

    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Dead")
            {
                /*int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                Debug.Log("Deduwa zaliczona, restart.");
                SceneManager.LoadScene(currentSceneIndex);*/
                TakeDamage(10);
                
            }
           // if(collision.gameObject.CompareTag("Flush"))
                // FindObjectOfType <AudioManager>().Play("Flush");
        }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //currentHealth -= maxHealth;
        healthBar.Sethealth(currentHealth);
        if (currentHealth <= 70)
        {
            foreach (GameObject i in healthImg)
            {
                
                healthImg[0].SetActive(false);
                healthImg[1].SetActive(true);
            }
        }
        else if (currentHealth <= 30)
        {
            foreach (GameObject i in healthImg)
            {
                healthImg[1].SetActive(false);
                healthImg[2].SetActive(true);
            }
        }
        else if(currentHealth>=71)
        {
            healthImg[0].SetActive(true);
        }
    }
    
}
