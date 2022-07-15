using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour


{
    public gun Gun;
    public GameObject pauseScreen;
    public GameObject winScreen;
    public GameObject Shild;
    public GameObject loseScreen;
    public healthMan manHP;
    public healthWooman woomanHP;
    public shootingMan shoootMan;
    [SerializeField] private Transform shildPosition;
    public float time = 15f;
    public Text timer;

    private void Start()
    {
        Time.timeScale = 1f;
        timer.text = time.ToString();
    }

    private void Update()
    {
        if (manHP.currentHp > 0)
        {
            time -= Time.deltaTime;
            timer.text = Mathf.Round(time).ToString();
        }
        
            win();
            lose();
        
        
    }


    public void pauseOn()
    {

        Time.timeScale = 0f;
        Gun.enabled = false;
        pauseScreen.SetActive(true);
        

    }

    public void pauseOff()
    {
        Time.timeScale = 1f;
        Gun.enabled = true;
        pauseScreen.SetActive(false);
       
    }

    public void restart()
    {
        
        
        SceneManager.LoadScene(0);
       
    }

    public void shild()
    {
        if (time <= 0)
        {
            Instantiate(Shild, shildPosition.position, transform.rotation);
        }
    }

    public void win()
    {
        
        if (manHP.currentHp <= 0) 
        {
            Gun.enabled = false;
            winScreen.SetActive(true);
            
            
        }
        
    }
    
    public void lose()
    {
        
        if(woomanHP.currentHp <= 0)
        {

            Time.timeScale = 0f;
            loseScreen.SetActive(true);
          
            
        }
    }
}
