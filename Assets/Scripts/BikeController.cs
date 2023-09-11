using UnityEngine;

namespace Chapter.State
{
    public class BikeController : MonoBehaviour
    {

        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;
        public Rigidbody rb;
        public bool _isGrounded
        {
            get { return Physics.Raycast(transform.position, -Vector3.up, 1f, groundLayer); }
        }
        public LayerMask groundLayer;
        public float JumpVelocity = 7.0f;
        public float DiveVelocity = 2.0f;

        public float CurrentSpeed { get; set; }

        public Direction CurrentTurnDirection
        {
            get; private set;
        }

        private IBikeState
            /*_startState, _stopState,*/ _jumpState, _diveState, _duckState, _standState, _shrinkState, _stretchState, _enlargeState, _turnState;

        private BikeStateContext _bikeStateContext;

        private void Start()
        {
            _bikeStateContext =
                new BikeStateContext(this);
            /*
            _startState =
                gameObject.AddComponent<BikeStartState>();
            _stopState =
                gameObject.AddComponent<BikeStopState>();
            */
            /*
            _bikeStateContext.Transition(_stopState); */

            _turnState =
                gameObject.AddComponent<BikeTurnState>();

            _jumpState =
                gameObject.AddComponent<JumpState>();

            _diveState =
                gameObject.AddComponent<DiveState>();

            _duckState =
                gameObject.AddComponent<DuckState>();

            _standState =
                gameObject.AddComponent<StandState>();

            _shrinkState =
                gameObject.AddComponent<ShrinkState>();

            _stretchState =
                gameObject.AddComponent<StretchState>();

            _enlargeState =
                gameObject.AddComponent<EnlargeState>();
        }
        /*
        public void StartBike()
        {
            _bikeStateContext.Transition(_startState);
        }

        public void StopBike()
        {
            _bikeStateContext.Transition(_stopState);
        }
        */
        
        public void Turn(Direction direction)
        {
            CurrentTurnDirection = direction;
            _bikeStateContext.Transition(_turnState);
        }

        public void Jump()
        {
            _bikeStateContext.Transition(_jumpState);
        }

        public void Dive()
        {
            _bikeStateContext.Transition(_diveState);
        }

        public void Duck()
        {
            _bikeStateContext.Transition(_duckState);
        }
      
        public void Stand()
        {
            _bikeStateContext.Transition(_standState);
        }

        public void Shrink()
        {
            _bikeStateContext.Transition(_shrinkState);
        }

        public void Stretch()
        {
            _bikeStateContext.Transition(_stretchState);
        }

        public void Enlarge()
        {
            _bikeStateContext.Transition(_enlargeState);
        }
    }
}