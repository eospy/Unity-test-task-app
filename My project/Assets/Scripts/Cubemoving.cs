using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cubemoving : MonoBehaviour
{
    [SerializeField] private InputField inputdist;
    [SerializeField] private InputField inputspeed;
    [SerializeField] private InputField inputperiod;
    private int period;
    private int distance;
    private int speed;
    float counter = 0;
    int j = 0;
    // Start is called before the first frame update
    Transform move;
    public GameObject redcube;
    void Start()
    {
        speed = Int32.Parse(inputspeed.text);
        distance = Int32.Parse(inputdist.text);
        period = Int32.Parse(inputperiod.text);
        move = transform;
        move.position = new Vector3(0, 1.8f, 0);
    }

    // Update is called once per frame  
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > period)
        {
            
            GameObject duplicate = Instantiate(redcube);
            counter = 0;
            j++;
        }

        if (move.position.z < distance)
        {
            move.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
        else if (j > 0)
        {
            Destroy(this.gameObject);
            j--;
            return;
        }

    }
    
}
