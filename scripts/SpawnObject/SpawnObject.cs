
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SpawnObject : UdonSharpBehaviour
{
    [SerializeField] private GameObject targetObject;

    private void OnTriggerEnter(Collider other)
    {
        var r = other.GetComponent<Rigidbody>();
        if (r == null) return;

        VRCInstantiate(targetObject);

    }
}