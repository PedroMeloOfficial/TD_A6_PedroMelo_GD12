using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {
    private NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start() {
        // Get the component type "NavMeshAgent"
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
        // Check if the left mouse button as clicked
        if (Input.GetMouseButtonDown(0)) {
            // Create a variable to store the information of rayCast
            Ray rayCast;
            // Use the camera to convert the mouse screen coordinated into a 3d world space coordinates
            rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Raycast along the array, to maximaxe distance of 10000f
            // store the result in a variable type RaycastHit named "hit"
            if (Physics.Raycast(rayCast, out RaycastHit hit, 10000f)) {
                navAgent.SetDestination(hit.point);
            }
        }
    }

}