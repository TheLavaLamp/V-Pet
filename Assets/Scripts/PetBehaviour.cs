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
        stamina.value = 1.0f;
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
            Destroy(other.gameObject);
            if(stamina.value < 1.0f)
            {
                stamina.value += 0.1f;
            }
        }
    }

    IEnumerator DecreaseStamina()
    {
        while(true)
        {
            yield return new WaitForSeconds(10);
            if (stamina.value > 0.0f)
            {
                stamina.value -= 0.1f;
            }
        }
    }
}
