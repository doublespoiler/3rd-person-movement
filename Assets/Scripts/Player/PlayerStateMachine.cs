using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [field: SerializeField]
    public InputReader InputReader { get; private set; }
    // Start is called before the first frame update
    private void Start()
    {
      SwitchState(new PlayerTestState(this));
    }

}
