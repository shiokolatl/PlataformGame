using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] Transform iniPos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Danger"))
        {
            _gameManager.lifes -= 1;
            transform.position = iniPos.position;
        }
    }
}
