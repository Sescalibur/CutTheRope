using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private int levelUp;

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.tag == "Candy")
        {
            levelUp++;
            SceneManager.LoadScene(levelUp);
        }
    }
}
