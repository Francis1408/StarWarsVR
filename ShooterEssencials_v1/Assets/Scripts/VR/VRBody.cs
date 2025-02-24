using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRBody : MonoBehaviour
{
    public CapsuleCollider capsuleCollider;
    public Transform playerHead;
    public Transform playerRoot;


    // Update is called once per frame
    void Update()
    {
        Vector3 position = playerRoot.InverseTransformPoint(playerHead.position);
        float height = position.y;
        position.y = position.y / 2;
        capsuleCollider.center = position;
        capsuleCollider.height = height;
    }
}
