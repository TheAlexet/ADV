﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField]
    private GameObject player;

    void LateUpdate()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x - 0.2f, player.transform.position.y + 0.2f, player.transform.position.z - 0.2f);
        gameObject.transform.rotation = Quaternion.Euler(player.transform.localRotation.x, player.transform.localRotation.y, player.transform.localRotation.z);
    }

}
