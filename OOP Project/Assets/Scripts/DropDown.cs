using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI output;
    public ParticleSystem explosion;
    public GameObject dollarSign;

    //ENCAPSULATION. Prevents the user from inputting a negative time for the dollar sign to vanish
    private int m_dollarSignAppearenceTime = 1;
    public int dollarSignAppearenceTime
    {
        get { return m_dollarSignAppearenceTime; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative time!");
            }
            else
            {
                m_dollarSignAppearenceTime = value;
            }
        }
    }





    public float rotationSpeed;

    private void Start()
    {
       
    }

    public void HandleInputData (int val)
    {
        if (val == 0)
        {
            output.text = "Don't give up!";
        }

        if (val == 1)
        {
            output.text = "Try again!";
        }

        if (val == 2)
        {
            output.text = "So close!";
        }

        if (val == 3)
        {
            output.text = "You got it!";
            explosion.Play();
            dollarSign.gameObject.SetActive(true);

            //ENCAPSULATION CONT. Here the user can put "-=" and it will trigger the Debug.LogError message
            dollarSignAppearenceTime *= 3;
            StartCoroutine(DollarSignCountdown());


        }


    }

    void Update()
    {
        dollarSign.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    IEnumerator DollarSignCountdown()
    {
        yield return new WaitForSeconds(m_dollarSignAppearenceTime);
        dollarSign.gameObject.SetActive(false);

    }

}
