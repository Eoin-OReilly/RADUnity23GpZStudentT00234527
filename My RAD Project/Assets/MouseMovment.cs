

public class MouseMovment 
{
    public float sensX;
    public float sensY;

    public transform orientation;

    float xRotation;
    float yRotation;

    
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.vivible = false;

    }

    
    void Update()
    {
            //Mouse Input
      float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
      float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

      yRotation += mouseX;

      xRotation -= mouseY;
      xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            //  Rotation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);



    }
}
