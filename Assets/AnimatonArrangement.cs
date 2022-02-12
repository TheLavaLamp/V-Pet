using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatonArrangement : MonoBehaviour
{
    public Animator faceAnim;
    public Animator bodyAnim;


    public void Idle()
    {
        faceAnim.SetTrigger("Idle");
        bodyAnim.SetTrigger("Idle");
    }
    public void Run()
    {
        faceAnim.SetTrigger("Run");
        bodyAnim.SetTrigger("Run");
    }
    public void Walk()
    {
        faceAnim.SetTrigger("Walk");
        bodyAnim.SetTrigger("Walk");
    }
    public void Eat()
    {
        faceAnim.SetTrigger("Eat");
        bodyAnim.SetTrigger("Eat");
    }
    public void Love()
    {
        Debug.Log("Love");
        faceAnim.SetTrigger("Love");
        bodyAnim.SetTrigger("Love");
    }
        public void LoveLeft()
    {
        faceAnim.SetTrigger("LoveLeft");
        bodyAnim.SetTrigger("LoveLeft");
    }
        public void LoveRight()
    {
        faceAnim.SetTrigger("LoveRight");
        bodyAnim.SetTrigger("LoveRight");
    }

    public void Sad()
    {
        faceAnim.SetTrigger("Sad");
        bodyAnim.SetTrigger("Sad");
    }


}
