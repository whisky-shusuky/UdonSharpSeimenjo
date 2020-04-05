using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SetGravitation : UdonSharpBehaviour {
    [SerializeField] private float power = 1.0f;
    [SerializeField] private GameObject gravitationTarget;

    private void OnTriggerStay (Collider other) {
        var r = other.GetComponent<Rigidbody> ();
        if (r == null) return;

        var vec = gravitationTarget.transform.position - other.transform.position;
        var dic = vec.normalized;
        r.AddForce (dic * power, ForceMode.Acceleration);
    }
}
