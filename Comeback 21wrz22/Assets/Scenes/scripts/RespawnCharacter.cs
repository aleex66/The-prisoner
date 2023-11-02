using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RespawnCharacter : MonoBehaviour
{
    public GameObject[] healthImg;
    public float maxHealth;
    public float currentHealth;
    public float percInc = 0.1f;
    public float picChg = 0.3f;
    public float low;
    public float med;
    public HealthBar healthBar;

    public void Start()
    {
        low = maxHealth * picChg;
        med = maxHealth - low;
        currentHealth = maxHealth;
        healthBar.MaxHealth(maxHealth);
        healthBar.Sethealth(currentHealth);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            TakeDamage(percInc);
        }
    }

    public void TakeDamage(float damage)
    {
        damage = maxHealth * percInc;
        currentHealth-=damage;
       
            if(currentHealth>med)
            {
                HighHealth();
            }
            else if(currentHealth<=med)
            {
                 MediumHealth();
            }
            else if (currentHealth<=low)
            {
                LowHealth();
            }
            if (currentHealth == 0)
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                Debug.Log("Deduwa zaliczona, restart.");
                SceneManager.LoadScene(currentSceneIndex);
            }
            healthBar.Sethealth(currentHealth);

    }  
    
   public void HighHealth()
    {
        foreach (GameObject health in healthImg)
        {
            Debug.Log("You are a happy 100% healthy Evis!");  
        }
    }

     public void MediumHealth()
    {
        Debug.Log("You have less than 50% health. Be careful!");
        foreach (GameObject health in healthImg)
        {
            healthImg[0].SetActive(false);
            healthImg[1].SetActive(true);
        }

    }

     public void LowHealth()
     {
         Debug.Log("You are almost dead dumbass");
        foreach (GameObject health in healthImg)
        {
            healthImg[1].SetActive(false);
            healthImg[2].SetActive(true);
        }
    }
     
}