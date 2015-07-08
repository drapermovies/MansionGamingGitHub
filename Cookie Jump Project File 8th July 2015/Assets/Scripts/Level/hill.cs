using UnityEngine;
using System.Collections;

public class hill : MonoBehaviour
{

    public Transform Player;
    public Transform hill1Transform;
    public Transform hill2Transform;
    public Transform grass;

    public bool hill1Move;
    public bool hill2Move;

    int hill1frames;
    int hill2frames; 

    void Start()
    {
        //hill1Move = true;
        //hill2Move = false;
    }

    void Update()
    {
        Vector3 increase = new Vector3(-10, -60, 0);

        grass.transform.position += increase;

        if (!hill1Move && !hill2Move)
        {
            hill1Move = true;
        }
        if (Player.position.x > hill1Transform.position.x + 15) {
            hill1Move = false;
            if (hill1Move)
            {
               // Vector3 increase = new Vector3(-10, -60, 0);
                hill1frames += 1;
                hill2Transform.transform.position += increase;
                Debug.Log("hill 1 frames = " + hill1frames);
                Debug.Log("hill 1 move");
                hill2Move = true;
            }
            //startCoroutine(hill1Coroutine());
        }
        if (Player.position.x > hill2Transform.position.x + 15)
        {
            hill1Move = true;
            hill2Move = false;
            if (hill2Move)
            {
                //Vector3 increase2 = new Vector3(-20, -60, 0);
                hill2frames += 1;
                hill1Transform.transform.position += increase;
                Debug.Log("hill 2 move");
                Debug.Log("hill 2 frames = " + hill2frames);
            }
        }

     /* IEnumerator hill1Coroutine()
       {
          StopCoroutine(hill1Coroutine());
       }*/
    }
}
