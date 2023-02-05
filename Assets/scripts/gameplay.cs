using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameplay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _timer;
    public GameObject player;
    public GameObject coin;
    bool reset = false;
    bool coin_start = false;
    public GameObject canva;

    void Start()
    {
        StartCoroutine("deley");
        
        Instantiate(player, new Vector3(Random.Range(-650, 390), 96, Random.Range(270, 780)), coin.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        if(timer.timelift <= 0 && reset == false && _timer.active)
        {
            reset = true;
            GameObject pl = GameObject.FindGameObjectWithTag("Player");
            LeanTween.reset();
            LeanTween.scale(pl, new Vector3(0, 0, 0), 0.8f).setEase(LeanTweenType.easeInCirc).setDelay(0.3f).setOnComplete(() => {
                GameObject[] destroy =  GameObject.FindGameObjectsWithTag("eat");
                foreach (GameObject child in destroy)
                    Destroy(child);
                canva.transform.GetChild(0).gameObject.GetComponent<AutoFlip>().FlipRightPage();
                StartCoroutine("deley_of_retrying");
            });
        }

    }
    IEnumerator deley()
    { 
        while(coin_start == false)
        {
            yield return new WaitForSeconds(Random.Range(4, 7));
            Instantiate(coin, new Vector3(Random.Range(-650, 390), 96, Random.Range(270, 780)), coin.transform.rotation);
        }
      
    }
    IEnumerator deley_of_retrying()
    {

        yield return new WaitForSeconds(1.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
}
