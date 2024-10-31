using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson02 : MonoBehaviour
{
    // Start is called before the first frame update
    private int lives = 3;
    void Start()
    {

        while (lives > 0)
        {
            if (lives == 3)
            {
                Debug.Log("Many Lives");
            }
            else if (lives == 1)
            {
                Debug.Log("The Last Life");
            }

            lives--;
            if (lives == 0)
            {
                Debug.Log("Game Over");
            }
        }
    }


}
