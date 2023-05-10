using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SittingController : NetworkBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Animator animator;
    [SerializeField] private string animationName;
    [SerializeField] private GameObject sittingPosition;
    [SerializeField] private Vector3 sittingOffset;

    private GameObject player;
    public bool isSitting = false;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private void Start()
    {
        player = gameObject;
        originalPosition = player.transform.position;
        originalRotation = player.transform.rotation;
    }

    private void Update()
    {
        if (!isLocalPlayer)
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isSitting)
            {
                CmdStandUp();
            }
            else
            {
                CmdSitOnStool();
            }
        }
    }

    [Command]
    private void CmdSitOnStool()
    {
        if (!isSitting)
        {
            RpcPlaySitAnimation();
            isSitting = true;

            // Store the player's original position and rotation
            originalPosition = player.transform.position;
            originalRotation = player.transform.rotation;

            // Set the player's position and rotation to the sitting position
            player.transform.position = sittingPosition.transform.position + sittingOffset;
            player.transform.rotation = sittingPosition.transform.rotation;
        }
    }

    [ClientRpc]
    private void RpcPlaySitAnimation()
    {
        animator.SetBool("Sitting", true);
        animator.SetBool("Walking", false);
    }

    [Command]
    private void CmdStandUp()
    {
        if (isSitting)
        {
            RpcPlayStandUpAnimation();
            isSitting = false;

            // Reset the player's position and rotation to the original values
            player.transform.position = originalPosition;
            player.transform.rotation = originalRotation;
        }
    }

    [ClientRpc]
    private void RpcPlayStandUpAnimation()
    {
        animator.SetBool("Sitting", false);
        animator.SetBool("Walking", false);
    }
}
