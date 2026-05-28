using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {
    [SerializeField]
    float recommendedSpeed;

    new Transform transform;
    Vector3 simulationPosition;

    public Vector3 Position {
        get {
            return simulationPosition;
        }
    }

    public float RecommendedSpeed {
        get {
            return recommendedSpeed;
        }
    }

    void Awake() {
        transform = GetComponent<Transform>();
        simulationPosition = transform.position;
    }
}
