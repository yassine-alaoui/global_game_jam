using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _timer;
    public GameObject player;
    public GameObject coin;
    bool reset = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.timelift <= 0 && reset == false && _timer.active)
        {
            reset = true;
            LeanTween.reset();
            LeanTween.scale(player, new Vector3(0, 0, 0), 0.8f).setEase(LeanTweenType.easeInCirc).setDelay(0.3f);
        }
        StartCoroutine("deley");

    }
    IEnumerator deley()
    { //mousePos.x < 1800 && mousePos.x > 100
        yield return new WaitForSeconds(Random.Range(2, 5));
        Instantiate(coin, new Vector3(Random.Range(110 , 170), 96, Random.Range(110, 170)),coin.transform.rotation);
    }
}
