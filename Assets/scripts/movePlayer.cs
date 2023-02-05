using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Vector3 target;
    public float speed = 5f;
    private Animator animate;
    public GameObject chaP;
    // Start is called before the first frame update
    void Start()
    {
        target = chaP.transform.position;
        animate = chaP.GetComponent<Animator>();
        animate.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            target.x += 5;
            target.z += 1;
            LeanTween.move(chaP, target, 0.2f);
            animate.speed = 1;
        }
        else
        {
            animate.speed = 0;
        }
           
        //transform.position = Vector3.MoveTowards(transform.position, target, Random.Range(speed,speed * 5) * Time.deltaTime);
    }
}
