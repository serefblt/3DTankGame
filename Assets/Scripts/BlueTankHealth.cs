using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueTankHealth : MonoBehaviour
{
    float _blueHealth = 5;
    [SerializeField] Text _blueText;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bluetank"))
        {
            _blueHealth--;
            _blueText.text = _blueHealth.ToString();
        }

    }

  
}
