using UnityEngine;

namespace Chapter.State
{
    public class ClientState : MonoBehaviour
    {
        private BikeController _bikeController;

        void Start()
        {
            _bikeController =
                (BikeController)
                FindObjectOfType(typeof (BikeController));
        }

        void OnGUI ()
        {
          if (Input.GetKeyDown(KeyCode.Space) && _bikeController._isGrounded)
            {
                Debug.Log("Jump");
                _bikeController.Jump();
            }

            if (Input.GetKeyDown(KeyCode.S) && !_bikeController._isGrounded)
            {
                Debug.Log("Dive");
                _bikeController.Dive();
            }

            if(Input.GetKeyDown(KeyCode.D) && _bikeController._isGrounded)
            {
                Debug.Log("Duck");
                _bikeController.Duck();
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("Stand");
                _bikeController.Stand();
            }

            if(Input.GetKeyDown(KeyCode.A) && _bikeController._isGrounded)
            {
                Debug.Log("Shrink");
                _bikeController.Shrink();
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                Debug.Log("Normal");
                _bikeController.Stand();
            }

            if (Input.GetKeyDown(KeyCode.Q) && _bikeController._isGrounded)
            {
                Debug.Log("Stretch");
                _bikeController.Stretch();
            }

            if (Input.GetKeyUp(KeyCode.Q))
            {
                Debug.Log("Normal");
                _bikeController.Stand();
            }

            if (Input.GetKeyDown(KeyCode.E) && _bikeController._isGrounded)
            {
                Debug.Log("Enlarge");
                _bikeController.Enlarge();
            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                Debug.Log("Normal");
                _bikeController.Stand();
            }


            /* if (GUILayout.Button("Start Bike"))
                _bikeController.StartBike();
            if (GUILayout.Button("Turn Left"))
                _bikeController.Turn(Direction.Left);
            if (GUILayout.Button("Turn Right"))
                _bikeController.Turn(Direction.Right);
            if (GUILayout.Button("Stop Bike"))
                _bikeController.StopBike(); */
        }
    }
}
