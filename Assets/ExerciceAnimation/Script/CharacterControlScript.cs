using UnityEngine;

public class CharacterControlScript : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private string walkSpeedParameterName;

    [SerializeField]
    [Range(0f, 0.5f)]
    private float walkSpeedParameterValue;

    [SerializeField]
    private string jumpParameterName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the Animator Component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // When pressing the w key the speed is incremented
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat(walkSpeedParameterName, walkSpeedParameterValue += 0.2f * Time.deltaTime);
        }

        // When pressing the S key the speed is decremented
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat(walkSpeedParameterName, walkSpeedParameterValue -= 0.2f * Time.deltaTime);
        }

        // Clamp the walkSpeedParameterValue min to 0
        if (walkSpeedParameterValue <= 0)
        {
            walkSpeedParameterValue = 0;
        }

        // Clamp the walkSpeedParameterValue max to 0.5
        if (walkSpeedParameterValue >= 0.5f)
        {
            walkSpeedParameterValue = 0.5f;
        }

        // When pressing the space key the trigger is set
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(jumpParameterName);
        }
    }
}
