using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class DestroyGameObject : MonoBehaviour
{

    public GameObject GameManager;
    public ParticleSystem DestroyedEffect;
    public AudioSource Source;

    public GameObject DialogWarning;

    private float delay = 5f;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void closeWarning()
    {
        DialogWarning.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
      
        Vector3 position = transform.position;

        if (collision.collider.CompareTag("True"))  //White Cell
        {
            if (DestroyedEffect != null)
            {
                //var effect = PoolSystem.Instance.GetInstance<ParticleSystem>(DestroyedEffect);
                DestroyedEffect.time = 0.0f;
                DestroyedEffect.Play();
                DestroyedEffect.transform.position = position;
            }

            if (Source != null)
            {
                Source.Play();
            }

            gameObject.SetActive(false);
            
            //Destroy(this.gameObject);
            //Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("False")) //Red Cell
        {
            //Destroy(this.gameObject);
            //Destroy(collision.gameObject);
            this.gameObject.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
            GameManager.GetComponent<GameManager2>().Vibrate();
            DialogWarning.SetActive(true);
            Invoke("closeWarning", delay);
        }

        //collision.gameObject.SetActive(false);
        collision.gameObject.transform.position = new Vector3(11, 0, 0);

    }
}
