using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  //  void Update()
   // {
  //      gameObject.transform.Translate(0, speed, 0);
  //  }

    void Update()
    {
        transform.Translate(0, speed * Time.fixedDeltaTime, 0);
    }
}
