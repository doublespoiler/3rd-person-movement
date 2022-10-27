using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
  public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { }

  private float timer;

  public override void Enter()
  {
    stateMachine.InputReader.JumpEvent += OnJump;
  }

  public override void Tick(float deltaTime)
  {
    timer += deltaTime; //deltatime = time passed between previous and current frame
    Debug.Log(timer);
    
  }

  public override void Exit()
  {
    stateMachine.InputReader.JumpEvent -= OnJump;
  }

    public void OnJump()
  {
    stateMachine.SwitchState(new PlayerTestState(stateMachine));
  }
}
