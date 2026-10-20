using UnityEngine;

public class winfailscript : MonoBehaviour
{
    public GameObject Key;
    public GameObject TimerText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Enemy")
        {


            Time.timeScale = 0;
            Debug.Log("You Lose!");


        }
        if (other.gameObject.tag == "Key")
        {

            Destroy(Key);
            Debug.Log("You Win");


        }
        if (other.gameObject.tag == "Destination")
        {
            Time.timeScale = 0;
            Debug.Log("You Win!");
        }
    }
}
