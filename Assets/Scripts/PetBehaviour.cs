using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetBehaviour : MonoBehaviour
{
    
    private Slider stamina;

    // Start is called before the first frame update
    void Start()
    {
        stamina = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
        StartCoroutine("DecreaseStamina");
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
            if(stamina.value < 1.0f)
            {
                stamina.value += insect.staminaFill;
                Debug.Log(insect.staminaFill);
            }
            Destroy(other.gameObject);
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
