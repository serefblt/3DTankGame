using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedTankHealth : MonoBehaviour
{
    float _redHealth = 5;
    [SerializeField] Text _redText;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            _redHealth--;
            _redText.text = _redHealth.ToString();
            Destroy(collision.gameObject);
            if (_redHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
      
    }
}
