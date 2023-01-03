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
        healthBar.MaxHealth(maxHealth);
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
        }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //currentHealth -= maxHealth;
        healthBar.Sethealth(currentHealth);
        if (currentHealth <= 500)
        {
                healthImg[0].SetActive(false);
                healthImg[1].SetActive(true);
                if (currentHealth <= 100)
                {
            
                    healthImg[1].SetActive(false);
                    healthImg[2].SetActive(true);
            
                }
        }
    }
    
}
