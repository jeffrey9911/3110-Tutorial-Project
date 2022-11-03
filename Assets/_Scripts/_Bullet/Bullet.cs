using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(this.gameObject);

        this.gameObject.SetActive(false);
        if(collision.gameObject.tag == "Player")
        {
            //
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            //
            Destroy(collision.gameObject);
        }
    }
}
