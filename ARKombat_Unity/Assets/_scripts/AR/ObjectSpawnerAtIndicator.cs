﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace arkombat
{
    public class ObjectSpawnerAtIndicator : MonoBehaviour
    {
        public GameObject objectToSpawn;
        private PlacementIndicator placementIndicator;

        void Start()
        {
            placementIndicator = FindObjectOfType<PlacementIndicator>();
        }

        void Update()
        {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
                GameObject obj = Instantiate(objectToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);
            }
        }
    }
}
