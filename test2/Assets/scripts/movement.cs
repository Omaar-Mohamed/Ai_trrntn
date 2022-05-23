using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int backwardsHash;
    int runrightHash;
    int runleftHash;
    int runbackrightHash;
    int runbackleftHash;
    int jumpHash;
    Vector3 mouseX;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        backwardsHash = Animator.StringToHash("backwards");
        runrightHash = Animator.StringToHash("runningright");
        runleftHash = Animator.StringToHash("runningleft");
        runbackrightHash = Animator.StringToHash("runbackright");
        runbackleftHash = Animator.StringToHash("runbackleft");
        jumpHash = Animator.StringToHash("jump");
    }

    // Update is called once per frame
    void Update()
    {
        bool rr = animator.GetBool(runrightHash);
        bool rl = animator.GetBool(runleftHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool backwards = animator.GetBool(backwardsHash);
        bool rbr = animator.GetBool(runbackrightHash);
        bool rbl = animator.GetBool(runbackleftHash);
        bool ju = animator.GetBool(jumpHash);
        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");
        
        bool runrightPressed = Input.GetKey("w") & Input.GetKey("d") ? true : false;
        bool runleftPressed = Input.GetKey("w") & Input.GetKey("a") ? true : false;
        bool runbackrightPressed = Input.GetKey("s") & Input.GetKey("d") ? true : false;
        bool runbackleftPressed = Input.GetKey("s") & Input.GetKey("a") ? true : false;
        bool jumpPressed = Input.GetKey("space");
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }
        if (!backwards && backwardPressed)
        {
            animator.SetBool("backwards", true);
        }
        if (backwards && !backwardPressed)
        {
            animator.SetBool("backwards", false);
        }
        if (!rr && runrightPressed )
        {
            animator.SetBool("runningright", true);
        }
        if (rr && !runrightPressed)
        {
            animator.SetBool("runningright", false);
        }
        if(!rl && runleftPressed)
        {
            animator.SetBool("runningleft", true);
        }
        if (rl && !runleftPressed)
        {
            animator.SetBool("runningleft", false);
        }
        if (!rbr && runbackrightPressed)
        {
            animator.SetBool("runbackright", true);
        }
        if (rbr && !runbackrightPressed)
        {
            animator.SetBool("runbackright", false);
        }
        if (!rbl && runbackleftPressed)
        {
            animator.SetBool("runbackleft", true);
        }
        if (rbl && !runbackleftPressed)
        {
            animator.SetBool("runbackleft", false);
        }
        if(!ju && jumpPressed)
        {
            animator.SetBool("jump", true);
        }
        if (ju && !jumpPressed)
        {
            animator.SetBool("jump", false);
        }

    }
}
