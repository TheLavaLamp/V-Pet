using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PetBehaviour : MonoBehaviour
{
    
    private Slider stamina;

    private Vector2 startTouchPosition;
    private Vector2 currentPosition;
    private Vector2 endTouchPosition;
    private bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    // Start is called before the first frame update
    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if(sceneName == "Game")
        {
            stamina = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
            StartCoroutine("DecreaseStamina");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Insect")
        {
            InsectBehaviour insect = other.gameObject.GetComponent<InsectBehaviour>();
            if(stamina.value < 100.0f)
            {
                stamina.value += insect.staminaFill;
                Debug.Log(insect.staminaFill);
            }
            other.gameObject.SetActive(false);
            GetComponent<AnimatonArrangement>().Eat();
        }
    }

    IEnumerator DecreaseStamina()
    {
        while(true)
        {
            yield return new WaitForSeconds(10);
            if (stamina.value > 0.0f)
            {
                stamina.value -= 10.0f;
            }
        }
    }
}
